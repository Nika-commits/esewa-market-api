using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace esewa_market.Data.Entities;

[Table("cart_items")]
[Index(nameof(CartId), nameof(ProductId), IsUnique = true)]
public class CartItem
{
    public int Id { get; set; }

    public int CartId { get; set; }

    public int ProductId { get; set; }

    public required Product Product { get; set; }

    public required Cart Cart { get; set; }

    public int Quantity { get; set; }

}