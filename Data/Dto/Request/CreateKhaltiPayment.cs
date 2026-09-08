using Newtonsoft.Json;

namespace esewa_market.Data.Dto.Request;

public class CreateKhaltiPayment
{
    [JsonProperty("return_url")] public string ReturnUrl { get; set; } = "";

    [JsonProperty("website_url")] public string WebsiteUrl { get; set; } = "";

    [JsonProperty("amount")] public int Amount { get; set; }

    [JsonProperty("purchase_order_id")] public string PurchaseOrderId { get; set; }

    [JsonProperty("purchase_order_name")] public string PurchaseOrderName { get; set; }

    [JsonProperty("customer_info")] public CustomerInfo CustomerInfo { get; set; }

    [JsonProperty("amount_breakdown")] public List<AmountBreakdown>? AmountBreakdown { get; set; }

    [JsonProperty("label")] public string? Label { get; set; }

    [JsonProperty("product_details")] public IEnumerable<ProductDetails> ProductDetails { get; set; }

    [JsonProperty("merchant_username")] public string? MerchantUsername { get; set; }

    [JsonProperty("merchant_extra")] public string? MerchantExtra { get; set; }
}

public class CustomerInfo
{
    [JsonProperty(PropertyName = "name")] public string Name { get; set; }

    [JsonProperty(PropertyName = "email")] public string Email { get; set; }

    [JsonProperty(PropertyName = "phone")] public string? Phone { get; set; }
}

public class AmountBreakdown
{
    public AmountBreakdown(int amount, string label)
    {
        Amount = amount;
        Label = label;
    }

    [JsonProperty(PropertyName = "label")] public string Label { get; set; }

    [JsonProperty(PropertyName = "amount")]
    public int Amount { get; set; }
}

public class ProductDetails
{
    [JsonProperty(PropertyName = "identity")]
    public string Identity { get; set; }

    [JsonProperty(PropertyName = "name")] public string Name { get; set; }

    [JsonProperty(PropertyName = "total_price")]
    public int TotalPrice { get; set; }

    [JsonProperty(PropertyName = "quantity")]
    public int Quantity { get; set; }

    [JsonProperty(PropertyName = "unit_price")]
    public int UnitPrice { get; set; }
}


// {
// "return_url": "https://example.com/payment/",
// "website_url": "https://example.com/",
// "amount": 1300,
// "purchase_order_id": "test12",
// "purchase_order_name": "test",
// "customer_info": {
//     "name": "Khalti Bahadur",
//     "email": "example@gmail.com",
//     "phone": "9800000123"
// },
// "amount_breakdown": [
// {
//     "label": "Mark Price",
//     "amount": 1000
// },
// {
// "label": "VAT",
// "amount": 300
// }
// ],
// "product_details": [
// {
//     "identity": "1234567890",
//     "name": "Khalti logo",
//     "total_price": 1300,
//     "quantity": 1,
//     "unit_price": 1300
// }
// ],
// "merchant_username": "merchant_name",
// "merchant_extra": "merchant_extra"
// }