using esewa_market.Data;
using esewa_market.Data.Entities;
using esewa_market.Services.Interfaces;

namespace esewa_market.Services.Implementations;

public class OrderService(
    AppDbContext db,
    IUserService userService,
    IProductService productService
    ): IOrderService
{

    public async Task<Order> CreateOrder(Order order)
    {
        throw new NotImplementedException();
    }

    public async Task<Order?> GetOrderById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Order>> GetOrdersByUserId(int userId)
    {
        throw new NotImplementedException();
    }
}