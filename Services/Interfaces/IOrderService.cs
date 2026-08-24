using esewa_market.Data.Dto.Request;
using esewa_market.Data.Dto.Response;
using esewa_market.Data.Entities;

namespace esewa_market.Services.Interfaces;

public interface IOrderService
{
    Task<OrderResponse> CreateOrder(
        string firebaseUid,
        CreateOrderRequest request
    );

    Task<OrderResponse?> GetOrderById(
        int id,
        string firebaseUid
    );

    Task<List<OrderResponse>> GetOrdersByUserId(
        string firebaseUid
    );
}