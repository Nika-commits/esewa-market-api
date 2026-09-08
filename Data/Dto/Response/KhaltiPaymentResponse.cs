using Newtonsoft.Json;

namespace esewa_market.Data.Dto.Response;

public class KhaltiPaymentResponse
{
    [JsonProperty("pidx")] public string Pidx { get; set; } = "";

    [JsonProperty("payment_url")] public string PaymentUrl { get; set; } = "";

    [JsonProperty("expires_at")] public string ExpiresAt { get; set; } = "";

    [JsonProperty("expires_in")] public int ExpiresIn { get; set; }
}