using esewa_market.Data.Dto.Request;
using esewa_market.Data.Entities;

namespace esewa_market.Services.Interfaces;

public interface IUserService
{
    Task<User> CreateUser(CreateUserRequest user);
    Task<User> GetUserById(int id);
}