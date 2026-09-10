namespace esewa_market.Data.Dto.Response;

public class EsewaPaymentVerificationResponse
{
    public string ProductId { get; set; } = "";

    public string ProductName { get; set; } = "";

    public string TotalAmount { get; set; } = "";

    public string Code { get; set; } = "";

    public required TransactionDetails TransactionDetails { get; set; }

    public string MerchantName { get; set; } = "";
}

public abstract class TransactionDetails
{
    public string TransactionId { get; set; } = "";

    public string ReferenceId { get; set; } = "";

    public string Status { get; set; } = "";
}