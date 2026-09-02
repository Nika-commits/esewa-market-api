using esewa_market.Data;
using esewa_market.Data.Dto.Request;
using esewa_market.Data.Dto.Response;
using esewa_market.Data.Entities;
using esewa_market.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace esewa_market.Services.Implementations;

public class UserService(
    AppDbContext db
) : IUserService
{

    public async Task<User> CreateUser(CreateUserRequest user, string firebaseUid, string email)
    {
        var existingUser = await db.Users.FirstOrDefaultAsync(u => u.FirebaseUid == firebaseUid);
        if (existingUser != null) return existingUser;

        var newUser = new User
        {
            FirebaseUid = firebaseUid,
            Email = email,
            Username = user.Username,
            FullName = user.FullName,
            ProfilePicture = user.ProfilePicture
        };

        var savedUser = await db.Users.AddAsync(newUser);
        await db.SaveChangesAsync();
        return savedUser.Entity;
    }

    public async Task<UserResponse?> GetUserById(int id)
    {
        var user = await db.Users.FirstOrDefaultAsync(u => u.Id == id);
        if (user == null) return null;

        var defaultAddress = await db.Addresses
            .FirstOrDefaultAsync(a =>
                a.UserId == id &&
                a.IsDefaultAddress);


        var response = new UserResponse
        {
            Id = user.Id,
            FullName = user.FullName,
            Username = user.Username,
            Email = user.Email,
            Address = defaultAddress?.FullAddress,
            Phone = defaultAddress?.PhoneNumber,
            ProfilePicture = user.ProfilePicture ?? "",
        };

        return response;
    }

    public async Task<UserResponse?> GetCurrentUser(string firebaseUid)
    {
        var user = await db.Users.FirstOrDefaultAsync(u => u.FirebaseUid == firebaseUid);
        if (user == null) return null;


        var defaultAddress = await db.Addresses
            .FirstOrDefaultAsync(a =>
                a.UserId == user.Id &&
                a.IsDefaultAddress);


        var response = new UserResponse
        {
            Id = user.Id,
            FullName = user.FullName,
            Username = user.Username,
            Email = user.Email,
            Address = defaultAddress?.FullAddress,
            Phone = defaultAddress?.PhoneNumber,
            ProfilePicture = user.ProfilePicture ?? "",
        };

        return response;
    }

    public async Task<User?> UpdateUserProfile(CreateUserRequest user, string firebaseUid)
    {
        var currentUser = await db.Users.Where(u => u.FirebaseUid == firebaseUid).FirstOrDefaultAsync();
        if (currentUser == null) return null;

        if (user.Username != null)
        {
            currentUser.Username = user.Username;
        }

        if (user.FullName != null)
        {
            currentUser.FullName = user.FullName;
        }

        if (user.ProfilePicture != null)
        {
            currentUser.ProfilePicture = user.ProfilePicture;
        }

        await db.SaveChangesAsync();
        return currentUser;
    }

}