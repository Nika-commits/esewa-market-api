using esewa_market.Data.Dto.Request;
using esewa_market.Data.Dto.Response;
using esewa_market.Data.Entities;

namespace esewa_market.Services.Interfaces;

public interface IAddressService
{
    Task<List<UserAddressResponse>> GetAddresses(string firebaseUid);

    Task<UserAddressResponse?> GetAddressById(int id, string firebaseUid);

    Task<UserAddressResponse?> GetDefaultAddress(int userId);

    Task<UserAddressResponse> CreateAddress(
        string firebaseUid,
        CreateAddressRequest request
    );

    Task<UserAddressResponse> UpdateAddress(
        int id,
        string firebaseUid,
        CreateAddressRequest request
    );

    Task DeleteAddress(
        int id,
        string firebaseUid
    );

    Task SetDefaultAddress(
        int id,
        string firebaseUid);
}