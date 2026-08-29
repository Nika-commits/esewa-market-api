using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace esewa_market.Data.Entities;

[Table("orders")]
public class Order
{
    [Key] public int Id { get; set; }

    public User User { get; set; }

    public int UserId { get; set; }

    public bool IsPromocodeApplied { get; set; } = false;

    public string Address { get; set; } = "";

    public string Phone { get; set; } = "";

    public string? Promocode { get; set; }

    public string PaymentOption { get; set; } = "";

    public string PaymentId { get; set; } = "";

    public int Discount { get; set; } = 0;

    public int DeliveryCharge { get; set; }

    public string VehicleNumber { get; set; } = "";

    public string Status { get; set; } = "";

    public string PaymentStatus { get; set; } = "";

    public DateTime OrderDate { get; set; } = DateTime.UtcNow;

    public int TotalPrice { get; set; }

    public ICollection<OrderItems> OrderItems { get; set; } = [];
}