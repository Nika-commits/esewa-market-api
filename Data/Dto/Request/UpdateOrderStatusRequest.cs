namespace esewa_market.Data.Dto.Request;

public class UpdateOrderStatusRequest
{
    public required string Status { get; set; }
}

public class UpdateOrderPaymentStatusRequest
{
    public required string Status { get; set; }

    public required string PaymentId { get; set; }
}