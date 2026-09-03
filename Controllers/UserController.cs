using esewa_market.Data.Dto.Request;
using esewa_market.Data.Dto.Response;
using esewa_market.Data.Entities;
using esewa_market.Services.Interfaces;
using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Microsoft.AspNetCore.Mvc;

namespace esewa_market.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController(
    IUserService userService,
    IAddressService addressService
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
            Console.WriteLine(user);
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
        await Task.Delay(2000);
        var authorizationHeader = Request.Headers.Authorization.ToString();
        if (string.IsNullOrWhiteSpace(authorizationHeader) || !authorizationHeader.StartsWith("Bearer ",
                StringComparison.OrdinalIgnoreCase))
        {
            return Unauthorized("No Authorization Header");
        }

        var idToken = authorizationHeader["Bearer".Length..].Trim();

        try
        {
            var decodedToken = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(idToken);
            var firebaseUid = decodedToken.Uid;
            if (string.IsNullOrWhiteSpace(firebaseUid)) return Unauthorized("No Firebase UID");

            var result = await userService.UpdateUserProfile(
                user,
                firebaseUid
            );
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
        catch (FirebaseException)
        {
            return Unauthorized("Firebase Exception");
        }
    }

    [HttpPost("address")]
    public async Task<ActionResult<UserAddressResponse>> CreateAddress(
        [FromBody] CreateAddressRequest request)
    {
        await Task.Delay(2000);
        var firebaseUid = await GetFirebaseUid();
        if (firebaseUid is null) return Unauthorized();

        var response = await addressService.CreateAddress(firebaseUid, request);
        return Ok(response);
    }

    [HttpGet("address")]
    public async Task<ActionResult<List<UserAddressResponse>>> GetAddresses()
    {
        await Task.Delay(2000);
        var firebaseUid = await GetFirebaseUid();
        if (firebaseUid is null) return Unauthorized();

        var response = await addressService.GetAddresses(firebaseUid);
        return Ok(response);
    }

    [HttpGet("address/{id:int}")]
    public async Task<ActionResult<UserAddressResponse>> GetAddressById([FromRoute] int id)
    {
        await Task.Delay(2000);
        var firebaseUid = await GetFirebaseUid();
        if (firebaseUid is null) return Unauthorized();

        var response = await addressService.GetAddressById(id, firebaseUid);
        return Ok(response);
    }

    [HttpDelete("address/{id:int}")]
    public async Task<ActionResult> DeleteAddress([FromRoute] int id)
    {
        await Task.Delay(2000);
        var firebaseUid = await GetFirebaseUid();
        if (firebaseUid is null) return Unauthorized();

        await addressService.DeleteAddress(id, firebaseUid);
        return Ok();
    }

    [HttpPut("address/{id:int}")]
    public async Task<ActionResult<UserAddressResponse>> UpdateAddress(
        [FromRoute] int id,
        [FromBody] CreateAddressRequest request)
    {
        await Task.Delay(2000);
        var firebaseUid = await GetFirebaseUid();
        if (firebaseUid is null) return Unauthorized();

        var response = await addressService.UpdateAddress(id, firebaseUid, request);
        return Ok(response);
    }

    [HttpPatch("address/{id:int}/set-default")]
    public async Task<ActionResult> SetDefaultAddress([FromRoute] int id)
    {
        await Task.Delay(2000);
        var firebaseUid = await GetFirebaseUid();
        if (firebaseUid is null) return Unauthorized();

        await addressService.SetDefaultAddress(id, firebaseUid);
        return Ok();
    }


    private async Task<string?> GetFirebaseUid()
    {
        var authorizationHeader = Request.Headers.Authorization.ToString();
        if (string.IsNullOrWhiteSpace(authorizationHeader) ||
            !authorizationHeader.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase))
        {
            return null;
        }

        var idToken = authorizationHeader["Bearer".Length..].Trim();

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