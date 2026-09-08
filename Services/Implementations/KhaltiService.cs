using System.Text;
using esewa_market.Data;
using esewa_market.Data.Dto.Request;
using esewa_market.Data.Dto.Response;
using esewa_market.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace esewa_market.Services.Implementations;

public class KhaltiService(
    AppDbContext db
) : IKhaltiService
{
    private const string KhaltiUrl = "https://dev.khalti.com/api/v2/";
    private const string InitiateUrl = "epayment/initiate/";
    public const string LookupUrl = "epayment/lookup/";

    public async Task<KhaltiPaymentResponse?> InitiatePayment(
        int orderId,
        string authToken)
    {
        var order = await db.Orders
            .Where(o => o.Id == orderId).Include(order => order.OrderItems)
            .FirstOrDefaultAsync();
        if (order is null) throw new Exception("Order not found");
        var user = await db.Users
            .Where(u => u.Id == order.UserId)
            .FirstOrDefaultAsync();
        if (user is null) throw new Exception("User not found");

        var payload = new CreateKhaltiPayment
        {
            PurchaseOrderId = order.Id.ToString(),
            Amount = order.TotalPrice * 100,
            PurchaseOrderName = order.Id.ToString(),
            ReturnUrl = "https://esewa-market.vercel.app/payment-success",
            WebsiteUrl = "",
            MerchantUsername = "EsewaMarket",
            CustomerInfo = new CustomerInfo
            {
                Email = user.Email,
                Name = user.FullName,
            },
            AmountBreakdown =
            [
                new AmountBreakdown(amount: order.TotalPrice, label: "Total")
            ],
            Label = "Esewa Market",
            ProductDetails = order.OrderItems.Select(item => new ProductDetails
            {
                Name = item.ProductId.ToString(),
                Quantity = item.Quantity,
                Identity = item.OrderId.ToString(),
                TotalPrice = item.Price,
                UnitPrice = item.Price / item.Quantity
            }),
        };

        var jsonPayload = JsonConvert.SerializeObject(payload);
        var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

        var client = new HttpClient();
        client.DefaultRequestHeaders.Add("Authorization", $"Key {authToken}");
        var response = await client.PostAsync(KhaltiUrl + InitiateUrl, content);
        var responseContent = await response.Content.ReadFromJsonAsync<KhaltiPaymentResponse>();

        return responseContent;
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