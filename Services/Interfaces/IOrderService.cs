using esewa_market.Data.Entities;

namespace esewa_market.Services.Interfaces;

public interface IOrderService
{
    Task<Order> CreateOrder(Order order);
    Task<Order?> GetOrderById(int id);
    Task<List<Order>> GetOrdersByUserId(int userId);
}