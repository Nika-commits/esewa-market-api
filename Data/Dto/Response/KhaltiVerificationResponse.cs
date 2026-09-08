namespace esewa_market.Data.Dto.Response;

public class KhaltiVerificationResponse
{
    public string PIDX { get; set; } = "";

    public int TotalAmount { get; set; }

    public string Status { get; set; } = "";

    public string? TransactionId { get; set; } = "";

    public int Fee { get; set; }

    public bool Refunded { get; set; }
}