using esewa_market.Data;
using esewa_market.Data.Dto.Request;
using esewa_market.Data.Dto.Response;
using esewa_market.Data.Entities;
using esewa_market.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace esewa_market.Services.Implementations;

public class AddressService(
    AppDbContext db,
    IUserService userService
) : IAddressService
{

    public async Task<List<UserAddressResponse>> GetAddresses(string firebaseUid)
    {
        var userId = await userService.GetCurrentUser(firebaseUid);
        if (userId is null) throw new KeyNotFoundException("User not found");

        var addresses = await db.Addresses.Where(a => a.UserId == userId.Id).ToListAsync();
        return addresses
            .Select(ToResponse)
            .ToList();
    }

    public async Task<UserAddressResponse?> GetAddressById(int id, string firebaseUid)
    {
        var user = await userService.GetCurrentUser(firebaseUid);
        if (user is null) throw new KeyNotFoundException("User not found");

        var address = await db.Addresses.FirstOrDefaultAsync(a => a.Id == id && a.UserId == user.Id);
        return address is null ? null : ToResponse(address);
    }

    public async Task<UserAddressResponse?> GetDefaultAddress(int userId)
    {
        var address =
            await db.Addresses.FirstOrDefaultAsync(a => a.UserId == userId && a.IsDefaultAddress == true);
        return address is null ? null : ToResponse(address);
    }

    public async Task<UserAddressResponse> CreateAddress(
        string firebaseUid,
        CreateAddressRequest request)
    {
        var user = await userService.GetCurrentUser(firebaseUid);
        if (user is null) throw new KeyNotFoundException("User not found");

        var addressCount = await db.Addresses.CountAsync(a => a.UserId == user.Id);
        if (addressCount >= 5) throw new Exception("You can only have 5 addresses");

        if (addressCount == 0)
        {
            request.IsDefaultAddress = true;
        }


        if (request.IsDefaultAddress)
        {
            await ClearDefaultAddress(user.Id);
        }

        var address = new Address
        {
            UserId = user.Id,
            FullName = request.FullName,
            FullAddress = request.FullAddress,
            PhoneNumber = request.PhoneNumber,
            Label = request.Label,
            IsDefaultAddress = request.IsDefaultAddress,
            IsDefaultShippingAddress = request.IsDefaultShippingAddress,
        };

        await db.Addresses.AddAsync(address);
        await db.SaveChangesAsync();
        return ToResponse(address);
    }

    private async Task ClearDefaultAddress(int userId)
    {
        await db.Addresses
            .Where(a => a.UserId == userId && a.IsDefaultAddress == true)
            .ExecuteUpdateAsync(setters =>
                setters.SetProperty(a => a.IsDefaultAddress, false)
            );
    }

    public async Task<UserAddressResponse> UpdateAddress(int id,
        string firebaseUid,
        CreateAddressRequest request)
    {
        var user = await userService.GetCurrentUser(firebaseUid);
        if (user is null) throw new KeyNotFoundException("User not found");

        var address = await db.Addresses
            .FirstOrDefaultAsync(a => a.Id == id && a.UserId == user.Id);

        if (address is null) throw new KeyNotFoundException("Address not found");

        address.FullName = request.FullName;
        address.FullAddress = request.FullAddress;
        address.PhoneNumber = request.PhoneNumber;
        address.Label = request.Label;
        address.UpdatedAt = DateTime.UtcNow;

        await db.SaveChangesAsync();
        return ToResponse(address);
    }

    public async Task DeleteAddress(int id,
        string firebaseUid)
    {
        var user = await userService.GetCurrentUser(firebaseUid);
        if (user is null) throw new KeyNotFoundException("User not found");

        var result = await db.Addresses.Where(a => a.Id == id && a.UserId == user.Id)
            .FirstOrDefaultAsync();
        if (result is null) throw new KeyNotFoundException("Address not found");
        db.Addresses.Remove(result);
        await db.SaveChangesAsync();
    }

    public async Task SetDefaultAddress(int id, string firebaseUid)
    {
        var user = await userService.GetCurrentUser(firebaseUid);
        if (user is null) throw new KeyNotFoundException("User not found");

        var exists = await db.Addresses.AnyAsync(a => a.Id == id && a.UserId == user.Id);
        if (!exists) throw new Exception("Address not found");

        await ClearDefaultAddress(user.Id);

        await db.Addresses
            .Where(a => a.Id == id && a.UserId == user.Id)
            .ExecuteUpdateAsync(setters =>
                setters.SetProperty(a => a.IsDefaultAddress, true)
            );
    }

    private static UserAddressResponse ToResponse(Address address)
    {
        return new UserAddressResponse
        {
            Id = address.Id,
            FullName = address.FullName,
            PhoneNumber = address.PhoneNumber,
            FullAddress = address.FullAddress,
            Label = address.Label,
            IsDefaultAddress = address.IsDefaultAddress,
            IsDefaultShippingAddress = address.IsDefaultShippingAddress
        };
    }
}