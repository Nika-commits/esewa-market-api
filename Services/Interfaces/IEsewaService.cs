using esewa_market.Data.Dto.Response;

namespace esewa_market.Services.Interfaces;

public interface IEsewaService
{
    Task<EsewaPaymentVerificationResponse?> GetEsewaVerificationStatus(string refId);

    Task<OrderResponse?> VerifyEsewaPayment(
        int orderId,
        string refId,
        string firebaseUid
    );
}