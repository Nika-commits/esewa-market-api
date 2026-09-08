using esewa_market.Data.Dto.Request;
using esewa_market.Data.Dto.Response;

namespace esewa_market.Services.Interfaces;

public interface IKhaltiService
{
    Task<KhaltiPaymentResponse?> InitiatePayment(
        int orderId);

    Task<KhaltiVerificationResponse?> LookupPayment(
        KhaltiPaymentVerificationRequest request
    );

    Task<OrderResponse?> VerifyPayment(
        int orderId,
        string firebaseUid,
        string pidx
    );
}