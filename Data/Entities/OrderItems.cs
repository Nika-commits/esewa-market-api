using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace esewa_market.Data.Entities;

[Table("order_items")]
[PrimaryKey( nameof(OrderId), nameof(ProductId))]
public class OrderItems
{
    [Key]
    public int OrderId { get; set; }
    public Order Order { get; set; }

    public int ProductId { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }
}