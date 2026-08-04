using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace esewa_market.Data.Entities;

[Table("cart")]
[Index(nameof(UserId), IsUnique = true)]
public class Cart
{
    [Key]
    public int Id { get; set; }

    public int UserId { get; set; }

    public User? User { get; set; }

}