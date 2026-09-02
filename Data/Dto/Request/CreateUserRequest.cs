namespace esewa_market.Data.Dto.Request;

public record CreateUserRequest
{
    public string? Username { get; set; }

    public string? FullName { get; set; }

    public string? ProfilePicture { get; set; }
}