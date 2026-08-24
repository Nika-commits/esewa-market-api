using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace esewa_market.Data.Entities;

[Table("order_items")]

public class OrderItems
{
    [Key]
    public int Id { get; set; }
    public int OrderId { get; set; }
    public Order Order { get; set; }

    public int ProductId { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }
}