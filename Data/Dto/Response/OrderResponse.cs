namespace esewa_market.Data.Dto.Response;

public class OrderResponse
{
    public int Id { get; set; }

    public List<OrderItemResponse> OrderItems { get; set; }

    public string Address { get; set; }

    public string Phone { get; set; }

    public string PaymentOption { get; set; }

    public string? VehicleNumber { get; set; }

    public int DeliveryCharge { get; set; }

    public int Discount { get; set; }

    public string Status { get; set; }

    public int TotalPrice { get; set; }
    public DateTime OrderDate { get; set; }
}

public class OrderItemResponse
{
    public int ProductId { get; set; }

    public string ProductName { get; set; }

    public string ProductImage { get; set; }
    public string Brand { get; set; }
    public int Quantity { get; set; }

    public int Price { get; set; }
}