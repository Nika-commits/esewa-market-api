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

    private string _khaltiPublicKey = configuration["Khalti:PublicKey"] ?? throw new
        InvalidOperationException("Khalti Secret Key not configured");

    public async Task<KhaltiPaymentResponse?> InitiatePayment(
        int orderId,
        string authToken)
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
        client.DefaultRequestHeaders.Add("Authorization", $"Key {authToken}");
        var response = await client.PostAsync(KhaltiUrl + InitiateUrl, content);
        var responseContent = await response.Content.ReadAsStringAsync();
        logger.LogInformation("Khalti response: {responseContent}", responseContent);

        var responseObject = JsonConvert.DeserializeObject<KhaltiPaymentResponse>(responseContent);
        return responseObject;
    }

    public async Task<KhaltiVerificationResponse?> LookupPayment(KhaltiPaymentVerificationRequest request)
    {
        var jsonPayload = JsonConvert.SerializeObject(request);
        var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

        var client = new HttpClient();
        client.DefaultRequestHeaders.Add("Authorization", "");
        var response = await client.PostAsync(KhaltiUrl + LookupUrl, content);
        return await response.Content.ReadFromJsonAsync<KhaltiVerificationResponse>();
    }
}