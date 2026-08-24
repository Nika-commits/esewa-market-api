using esewa_market.Data.Dto.Request;
using esewa_market.Data.Entities;

namespace esewa_market.Services.Interfaces;

public interface IOrderService
{
    Task<Order> CreateOrder(
        string firebaseUid,
        CreateOrderRequest request
    );

    Task<Order?> GetOrderById(
        int id,
        string firebaseUid
    );

    Task<List<Order>> GetOrdersByUserId(int userId);
}