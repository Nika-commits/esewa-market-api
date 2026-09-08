namespace esewa_market.Data.Dto.Response;

public class KhaltiPaymentResponse
{
    public string PIDX { get; set; } = "";

    public string PaymentUrl { get; set; } = "";

    public string ExpiresAt { get; set; } = "";

    public int ExpiresIn { get; set; }
}