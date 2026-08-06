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
            Address = user.Address,
            FullName = user.FullName,
            PhoneNumber = user.Phone,
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
}