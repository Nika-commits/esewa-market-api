using esewa_market.Data;
using esewa_market.Data.Dto.Request;
using esewa_market.Data.Entities;
using esewa_market.Services.Interfaces;

namespace esewa_market.Services.Implementations;

public class UserService(
    AppDbContext db
    ) : IUserService
{

    public async Task<User> CreateUser(CreateUserRequest user)
    {
        throw new NotImplementedException();
    }

    public async Task<User> GetUserById(int id)
    {
        throw new NotImplementedException();
    }
}