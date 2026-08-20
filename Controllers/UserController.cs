using esewa_market.Data.Dto.Request;
using esewa_market.Data.Entities;
using esewa_market.Services.Interfaces;
using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Microsoft.AspNetCore.Mvc;

namespace esewa_market.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController(
    IUserService userService
) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateUser(CreateUserRequest user)
    {
        var authorizationHeader = Request.Headers.Authorization.ToString();
        if (string.IsNullOrWhiteSpace(authorizationHeader) || !authorizationHeader.StartsWith("Bearer ",
                StringComparison.OrdinalIgnoreCase))
            return Unauthorized();

        var idToken = authorizationHeader["Bearer".Length..].Trim();

        try
        {
            var decodedToken = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(idToken);
            var firebaseUid = decodedToken.Uid;
            var email = decodedToken.Claims.GetValueOrDefault("email")?.ToString();

            if (string.IsNullOrWhiteSpace(email)) return BadRequest("No User Email Found");

            var result = await userService.CreateUser(user, firebaseUid, email);

            return Ok(result);
        }
        catch (FirebaseAuthException)
        {
            return Unauthorized();
        }
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetUserById(int id)
    {
        var result = await userService.GetUserById(id);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetCurrentUser()
    {
        var authorizationHeader = Request.Headers.Authorization.ToString();
        if (string.IsNullOrWhiteSpace(authorizationHeader) ||
            !authorizationHeader.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
        {
            return Unauthorized();
        }

        var idToken = authorizationHeader["Bearer".Length..].Trim();
        try
        {
            var decodedToken = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(idToken);
            var firebaseUid = decodedToken.Uid;

            if (firebaseUid == null) return Unauthorized();

            var user = await userService.GetCurrentUser(firebaseUid);
            if (user == null) return NotFound();
            return Ok(user);
        }
        catch (FirebaseAuthException)
        {
            return Unauthorized();
        }
        catch (IOException)
        {
            return NotFound();
        }
    }

    [HttpPost("update-profile")]
    public async Task<IActionResult> UpdateUserProfile(CreateUserRequest user)
    {
        var authorizationHeader = Request.Headers.Authorization.ToString();
        if (string.IsNullOrWhiteSpace(authorizationHeader) || !authorizationHeader.StartsWith("Bearer ",
                StringComparison.OrdinalIgnoreCase))
        {
            return Unauthorized();
        }

        var idToken = authorizationHeader["Bearer".Length..].Trim();

        try
        {
            var decodedToken = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(idToken);
            var firebaseUid = decodedToken.Uid;
            if (string.IsNullOrWhiteSpace(firebaseUid)) return Unauthorized();

            var result = userService.UpdateUserProfile(
                user,
                firebaseUid
            );
            if(result == null) return NotFound();
            return Ok(result);
        }
        catch (FirebaseException)
        {
            return Unauthorized();
        }
    }
}