using System.Net.Http.Headers;
using System.Text;
using esewa_market.Data;
using esewa_market.Data.Dto.Request;
using esewa_market.Data.Dto.Response;
using esewa_market.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace esewa_market.Services.Implementations;

public class KhaltiService(
    AppDbContext db,
    ILogger<KhaltiService> logger,
    IConfiguration configuration
) : IKhaltiService
{
    private const string KhaltiUrl = "https://dev.khalti.com/api/v2/";
    private const string InitiateUrl = "epayment/initiate/";
    private const string LookupUrl = "epayment/lookup/";

    private readonly string _khaltiPublicKey = configuration["Khalti:PublicKey"] ?? throw new
        InvalidOperationException("Khalti Secret Key not configured");

    private readonly string _khaltiSecretKey = configuration["Khalti:SecretKey"] ??
                                               throw new InvalidOperationException(
                                                   "Khalti Secret Key not configured");

    public async Task<KhaltiPaymentResponse?> InitiatePayment(
        int orderId)
    {
        logger.LogInformation("Initiating Khalti payment for order {orderId}", orderId);
        var order = await db.Orders
            .Where(o => o.Id == orderId).Include(order => order.OrderItems)
            .FirstOrDefaultAsync();
        if (order is null) throw new Exception("Order not found");
        var user = await db.Users
            .Where(u => u.Id == order.UserId)
            .FirstOrDefaultAsync();
        if (user is null) throw new Exception("User not found");

        var phoneNumber = db.Addresses.Where(a => a.UserId == user.Id && a.IsDefaultAddress)
            .Select(a => a.PhoneNumber).FirstOrDefault();
        if (phoneNumber is null) throw new Exception("User phone number not found");

        var payload = new CreateKhaltiPayment
        {
            PurchaseOrderId = order.Id.ToString(),
            Amount = order.TotalPrice * 100,
            PurchaseOrderName = order.Id.ToString(),
            ReturnUrl = "https://esewa-market.vercel.app/payment-success",
            WebsiteUrl = "https://esewa-market.vercel.app/",
            MerchantUsername = "EsewaMarket",
            CustomerInfo = new CustomerInfo
            {
                Email = user.Email,
                Name = user.FullName,
                Phone = phoneNumber,
            },
            AmountBreakdown =
            [
                new AmountBreakdown(amount: order.TotalPrice * 100, label: "Total")
            ],
            Label = "Esewa Market",
            ProductDetails = order.OrderItems.Select(item => new ProductDetails
            {
                Name = item.ProductId.ToString(),
                Quantity = item.Quantity,
                Identity = item.OrderId.ToString(),
                TotalPrice = item.Price * 100,
                UnitPrice = item.Price / item.Quantity
            }),
        };

        var jsonPayload = JsonConvert.SerializeObject(payload);
        logger.LogInformation("Khalti payload: {jsonPayload}", jsonPayload);

        var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");


        var client = new HttpClient();
        client.DefaultRequestHeaders.Add("Authorization", $"Key {_khaltiSecretKey}");
        var response = await client.PostAsync(KhaltiUrl + InitiateUrl, content);
        var responseContent = await response.Content.ReadAsStringAsync();
        logger.LogInformation("Khalti response: {responseContent}", responseContent);

        var responseObject = JsonConvert.DeserializeObject<KhaltiPaymentResponse>(responseContent);
        return responseObject;
    }

    public async Task<KhaltiVerificationResponse?> LookupPayment(KhaltiPaymentVerificationRequest request)
    {
        var jsonPayload = JsonConvert.SerializeObject(request);
        var content = new StringContent(
            jsonPayload,
            Encoding.UTF8,
            "application/json");

        var client = new HttpClient();
        client.DefaultRequestHeaders.Add("Authorization", $"Key {_khaltiSecretKey}");

        var response = await client.PostAsync(KhaltiUrl + LookupUrl, content);
        var responseContent = await response.Content.ReadAsStringAsync();

        logger.LogInformation("Khalti lookup response: {Response}", responseContent);
        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(
                $"Khalti lookup failed: " +
                $"{response.StatusCode} - {responseContent}"
            );
        }

        return JsonConvert.DeserializeObject<KhaltiVerificationResponse>(responseContent);
    }

    public async Task<OrderResponse?> VerifyPayment(
        int orderId,
        string firebaseUid,
        string pidx)
    {
        var order = await db.Orders
            .Include(o => o.OrderItems)
            .ThenInclude(oi => oi.Product)
            .FirstOrDefaultAsync(o => o.Id == orderId);

        if (order is null)
        {
            throw new Exception("Order not found");
        }

        var user = await db.Users
            .FirstOrDefaultAsync(u => u.Id == order.UserId
                                      && u.FirebaseUid == firebaseUid);

        if (user is null) throw new UnauthorizedAccessException();

        var khaltiResponse = await LookupPayment(new KhaltiPaymentVerificationRequest
        {
            PIDX = pidx,
        });

        if (khaltiResponse is null)
        {
            throw new Exception("Invalid Khalti response");
        }

        if (khaltiResponse.Status != "Completed")
        {
            throw new Exception(
                $"Payment was not completed. Status: {khaltiResponse.Status}");
        }

        var expectedAmount = order.TotalPrice * 100;
        if (expectedAmount != khaltiResponse.TotalAmount)
        {
            throw new Exception("Khalti payment amount does not match order amount");
        }

        order.PaymentStatus = "Paid";
        order.PaymentId = khaltiResponse.TransactionId;
        order.Status = "Pending";

        await db.SaveChangesAsync();

        return new OrderResponse
        {
            Id = order.Id,
            Address = order.Address,
            Phone = order.Phone,
            PaymentOption = order.PaymentOption,
            DeliveryCharge = order.DeliveryCharge,
            Discount = order.Discount,
            Status = order.Status,
            TotalPrice = order.TotalPrice,
            VehicleNumber = order.VehicleNumber,
            OrderDate = order.OrderDate,
            OrderItems =
            [
                .. order.OrderItems.Select(i => new OrderItemResponse
                {
                    ProductId = i.ProductId,
                    ProductName = i.Product.Name,
                    Quantity = i.Quantity,
                    Price = i.Price
                })
            ]
        };
    }
}