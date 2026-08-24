using System.ComponentModel.DataAnnotations;

namespace esewa_market.Data.Dto.Request;

public class CreateOrderRequest
{
    [Required]
    public string Address { get; set; }
    public string? Phone { get; set; }
    public string PaymentOption { get; set; }
    public string? Promocode { get; set; }
    [Required]
    public List<CreateOrderItemRequest> Items { get; set; }
}

public class CreateOrderItemRequest
{
    [Required]
    public int ProductId { get; set; }

    [Required]
    public int Quantity { get; set; }
}