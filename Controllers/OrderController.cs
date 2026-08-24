using esewa_market.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace esewa_market.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderController(
    IOrderService orderService
    ): ControllerBase
{

}