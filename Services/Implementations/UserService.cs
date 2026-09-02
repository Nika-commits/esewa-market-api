using esewa_market.Data;
using esewa_market.Data.Dto.Request;
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

    public async Task<User?> GetUserById(int id)
    {
        return await db.Users.FirstOrDefaultAsync(u => u.Id == id);
    }

    public async Task<User?> GetCurrentUser(string firebaseUid)
    {
        return await db.Users.FirstOrDefaultAsync(u => u.FirebaseUid == firebaseUid);
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