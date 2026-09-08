using esewa_market.Data.Dto.Request;
using esewa_market.Data.Dto.Response;

namespace esewa_market.Services.Interfaces;

public interface IKhaltiService
{
    Task<KhaltiPaymentResponse?> InitiatePayment(
        int orderId,
        string authToken
    );

    Task<KhaltiVerificationResponse?> LookupPayment(
        KhaltiPaymentVerificationRequest request
    );
}