using Newtonsoft.Json;

namespace esewa_market.Data.Dto.Response;

public class KhaltiVerificationResponse
{
    [JsonProperty("pidx")] public string Pidx { get; set; } = "";

    [JsonProperty("total_amount")] public int TotalAmount { get; set; }

    [JsonProperty("status")] public string Status { get; set; } = "";

    [JsonProperty("transaction_id")] public string TransactionId { get; set; } = "";

    [JsonProperty("fee")] public int Fee { get; set; }

    [JsonProperty("refunded")] public bool Refunded { get; set; }
}