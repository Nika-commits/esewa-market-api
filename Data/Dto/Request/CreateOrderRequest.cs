using System.ComponentModel.DataAnnotations;

namespace esewa_market.Data.Dto.Request;

public class CreateOrderRequest
{
    [Required] public string Address { get; set; }

    public string? Phone { get; set; }

    public string PaymentOption { get; set; }

    public string? Promocode { get; set; }

    [Required] public List<CreateOrderItemRequest> Items { get; set; }
}

public class CreateOrderItemRequest
{
    [Required] public int ProductId { get; set; }

    [Required] public int Quantity { get; set; }
}

public enum OrdersFilter
{
    All,
    Pending,
    Delivered,
    Cancelled,
}

public class OrderFilterRequest
{
    public OrdersFilter Filter { get; set; } = OrdersFilter.All;

    public DateOnly? From { get; set; }

    public DateOnly? To { get; set; }
}