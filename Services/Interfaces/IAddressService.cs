using esewa_market.Data.Dto.Request;
using esewa_market.Data.Entities;

namespace esewa_market.Services.Interfaces;

public interface IAddressService
{
    Task<List<Address>> GetAddresses(string firebaseUid);

    Task<Address> CreateAddress(
        string firebaseUid,
        CreateAddressRequest request
    );

    Task<Address> UpdateAddress(
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