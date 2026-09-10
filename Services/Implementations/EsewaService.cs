using System.Globalization;
using esewa_market.Data;
using esewa_market.Data.Dto.Response;
using esewa_market.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace esewa_market.Services.Implementations;

public class EsewaService(
    AppDbContext db,
    UserService userService,
    OrderService orderService,
    IConfiguration configuration,
    ILogger<EsewaService> logger
) : IEsewaService

{
    private const string EsewaUrl = "https://rc.esewa.com.np/mobile/transaction";

    private readonly string _esewaMerchantId = configuration["Esewa:ClientId"] ??
                                               throw new InvalidOperationException("Esewa Merchant Id " +
                                                   "not configured");

    private readonly string _esewaSecretKey = configuration["Esewa:ClientSecret"] ??
                                              throw new InvalidOperationException(
                                                  "Esewa Secret Key not configured");

    public async Task<EsewaPaymentVerificationResponse?> GetEsewaVerificationStatus(string refId)
    {
        logger.LogInformation("Checking Esewa payment status for refId {refId}", refId);

        var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Add("MerchantId", _esewaMerchantId);
        httpClient.DefaultRequestHeaders.Add("MerchantSecret", _esewaSecretKey);

        var response = await httpClient.GetAsync(EsewaUrl + "?txnRefId=" + refId);
        var responseContent = await response.Content.ReadAsStringAsync();

        logger.LogInformation("Esewa payment status response: {responseContent}", responseContent);

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception(
                $"Esewa payment status lookup failed: " +
                $"{response.StatusCode} - {responseContent}"
            );
        }

        return JsonConvert.DeserializeObject<EsewaPaymentVerificationResponse>(responseContent);
    }

    public async Task<OrderResponse?> VerifyEsewaPayment(int orderId, string refId, string firebaseUid)
    {
        var user = await userService.GetCurrentUser(firebaseUid);
        if (user is null) throw new KeyNotFoundException("User not found");

        var order = await db.Orders
            .Where(o => o.Id == orderId && o.UserId == user.Id)
            .Include(order => order.OrderItems)
            .ThenInclude(oi => oi.Product)
            .FirstOrDefaultAsync();

        if (order is null) throw new KeyNotFoundException("Order not found");

        var verificationResponse = await GetEsewaVerificationStatus(refId);

        if (verificationResponse is null) throw new Exception("Esewa payment verification failed");

        if (verificationResponse.TransactionDetails?.Status != "COMPLETE")
            throw new Exception("Esewa " +
                                "payment verification failed");

        double totalAmount = order.TotalPrice;
        if (totalAmount.ToString(CultureInfo.InvariantCulture) != verificationResponse.TotalAmount)
            throw new Exception("Esewa payment amount does not match order amount");

        order.PaymentStatus = "Paid";
        order.PaymentId = verificationResponse.TransactionDetails.TransactionId;
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