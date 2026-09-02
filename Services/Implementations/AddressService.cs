using esewa_market.Data;
using esewa_market.Data.Dto.Request;
using esewa_market.Data.Entities;
using esewa_market.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace esewa_market.Services.Implementations;

public class AddressService(
    AppDbContext db,
    IUserService userService
) : IAddressService
{

    public async Task<List<Address>> GetAddresses(string firebaseUid)
    {
        var userId = await userService.GetCurrentUser(firebaseUid);
        if (userId is null) throw new KeyNotFoundException("User not found");

        var addresses = db.Addresses.Where(a => a.UserId == userId.Id).ToList();
        return addresses;
    }

    public async Task<Address?> GetDefaultAddress(int userId)
    {
        var address =
            await db.Addresses.FirstOrDefaultAsync(a => a.UserId == userId && a.IsDefaultAddress == true);
        return address;
    }

    public async Task<Address> CreateAddress(
        string firebaseUid,
        CreateAddressRequest request)
    {
        var user = await userService.GetCurrentUser(firebaseUid);
        if (user is null) throw new KeyNotFoundException("User not found");

        var address = new Address
        {
            UserId = user.Id,
            FullName = request.FullName,
            FullAddress = request.FullName,
            PhoneNumber = request.PhoneNumber,
            Label = request.Label,
            IsDefaultAddress = request.IsDefaultAddress,
            IsDefaultShippingAddress = request.IsDefaultShippingAddress,
        };

        await db.Addresses.AddAsync(address);
        await db.SaveChangesAsync();
        return address;
    }

    public async Task<Address> UpdateAddress(int id,
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
        return address;
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

        var addresses = await db.Addresses.Where(a => a.UserId == user.Id).ToListAsync();

        var selectedAddress = addresses.FirstOrDefault(a => a.Id == id);

        if (selectedAddress is null) throw new KeyNotFoundException("Address not found");

        foreach (var address in addresses)
        {
            address.IsDefaultAddress = address.Id == id;
        }

        await db.SaveChangesAsync();
    }
}