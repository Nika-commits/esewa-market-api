using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace esewa_market.Data.Entities;

[Table("address")]
public class Address
{
    [Key] public int Id { get; set; }

    public int UserId { get; set; }

    public User User { get; set; }

    public string FullName { get; set; } = "";

    public string PhoneNumber { get; set; } = "";

    public string FullAddress { get; set; } = "";

    public AddressLabel Label { get; set; } = AddressLabel.Home;

    public bool IsDefaultAddress { get; set; } = false;

    public bool IsDefaultShippingAddress { get; set; } = false;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}

public enum AddressLabel
{
    Home,
    Office,
    Other
}