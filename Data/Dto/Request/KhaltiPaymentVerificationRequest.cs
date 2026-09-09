using Newtonsoft.Json;

namespace esewa_market.Data.Dto.Request;

public class KhaltiPaymentVerificationRequest
{
    [JsonProperty("pidx")] public string PIDX { get; set; } = "";
}