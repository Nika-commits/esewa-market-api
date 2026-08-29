using esewa_market.Data.Dto.Request;
using esewa_market.Data.Dto.Response;
using esewa_market.Data.Entities;
using esewa_market.Services.Interfaces;
using FirebaseAdmin.Auth;
using Microsoft.AspNetCore.Mvc;

namespace esewa_market.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderController(
    IOrderService orderService
) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<OrderResponse>> CreateOrder(
        [FromBody] CreateOrderRequest request
    )
    {
        await Task.Delay(3000);
        var firebaseUid = await GetFirebaseUid();
        if (firebaseUid is null) return Unauthorized();

        try
        {
            var order = await orderService.CreateOrder(
                firebaseUid,
                request
            );
            return CreatedAtAction(nameof(GetOrderById), new { id = order.Id }, order);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<OrderResponse?>> GetOrderById(int id)
    {
        await Task.Delay(3000);
        var firebaseUid = await GetFirebaseUid();
        if (firebaseUid is null) return Unauthorized();

        var order = await orderService.GetOrderById(id, firebaseUid);
        if (order is null) return NotFound();
        return Ok(order);
    }

    [HttpGet]
    public async Task<ActionResult<List<OrderResponse>>> GetOrders(
        [FromQuery(Name = "status")] OrdersFilter filter
    )
    {
        await Task.Delay(2000);
        Console.WriteLine(filter);
        var firebaseUid = await GetFirebaseUid();
        if (firebaseUid is null) return Unauthorized();

        var orders = await orderService.GetOrdersByUserId(
            filter,
            firebaseUid
        );
        return Ok(orders);
    }

    [HttpPatch("{id:int}/status")]
    public async Task<ActionResult<OrderResponse?>> UpdateOrderStatus(
        [FromRoute] int id,
        [FromBody] UpdateOrderStatusRequest request
    )
    {
        await Task.Delay(2000);
        var firebaseUid = await GetFirebaseUid();
        if (firebaseUid is null) return Unauthorized();

        try
        {
            var updatedOrder = await orderService.UpdateOrderStatus(id, firebaseUid, request.Status);
            if (updatedOrder is null) return NotFound();
            return Ok(updatedOrder);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    private async Task<string?> GetFirebaseUid()
    {
        var authorizationHeader = Request.Headers.Authorization.ToString();
        if (string.IsNullOrWhiteSpace(authorizationHeader) ||
            !authorizationHeader.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
        {
            return null;
        }

        var idToken = authorizationHeader["Bearer ".Length..].Trim();
        try
        {
            var decodedToken = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(idToken);
            return decodedToken.Uid;
        }
        catch (FirebaseAuthException)
        {
            return null;
        }
    }

}