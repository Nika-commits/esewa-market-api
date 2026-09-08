namespace esewa_market.Data.Dto.Request;

public class CreateKhaltiPayment
{
    public int Amount { get; set; }

    public string PurchaseOrderId { get; set; }

    public string PurchaseOrderName { get; set; }

    public CustomerInfo CustomerInfo { get; set; }

    public List<AmountBreakdown> AmountBreakdown { get; set; } = [];

    public string? Label { get; set; }

    public List<ProductDetails> ProductDetails { get; set; } = [];

    public string? MerchantUsername { get; set; }

    public string? MerchantExtra { get; set; }
}

public class CustomerInfo
{
    public string Name { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }
}

public class AmountBreakdown
{
    public string Label { get; set; }

    public int Amount { get; set; }
}

public class ProductDetails
{
    public string Identity { get; set; }

    public string Name { get; set; }

    public int TotalPrice { get; set; }

    public int Quantity { get; set; }

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