using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace esewa_market.Data.Entities;

[Table("users")]
[Index(nameof(Email), IsUnique = true)]
[Index(nameof(FirebaseUid), IsUnique = true)]
[Index(nameof(Username), IsUnique = true)]
public class User
{
    [Key] public int Id { get; set; }

    [MaxLength(255)] public required string FirebaseUid { get; set; }

    [MaxLength(255)] public required string Username { get; set; }

    [MaxLength(100)] public string FullName { get; set; } = "";

    [EmailAddress] [MaxLength(500)] public required string Email { get; set; }

    [MaxLength(255)] public string? ProfilePicture { get; set; }

    public ICollection<Address> Addresses { get; set; } = [];
}