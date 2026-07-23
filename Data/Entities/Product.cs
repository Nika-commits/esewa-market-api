using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using esewa_market.Data.Enums;

namespace esewa_market.Data.Entities;

[Table("products")]
public class Product
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }

    public List<string>? ImageUrls { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int Price{ get; set; }

    public string? Status { get; set; }
    public string? Description { get; set; }
    public string? Brand { get; set; }

    public required List<Color> Colors { get; set; } = [];
    public List< string> Sizes { get; set; }

    public bool IsFeatured { get; set; } = false;


}