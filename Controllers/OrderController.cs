using esewa_market.Data.Entities;
using esewa_market.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace esewa_market.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderController(
    IOrderService orderService
) : ControllerBase
{
    public async Task<ActionResult<Order>> CreateOrder(int userId)
    {
        throw new NotImplementedException();
    }

}