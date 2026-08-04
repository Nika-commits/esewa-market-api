namespace esewa_market.Data.Dto.Request;

public record CreateUserRequest
{
    string Username { get; set; }
    string FullName { get; set; }
    string? Address { get; set; }
    string? Phone { get; set; }
}