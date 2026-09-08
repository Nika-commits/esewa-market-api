using esewa_market.Data.Dto.Request;

namespace esewa_market.Services.Interfaces;

public interface IKhaltiService
{
    Task<string> InitiatePayment(CreateKhaltiPayment request);
    Task<string> LookupPayment(string transactionId);
}