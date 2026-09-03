using esewa_market.Data.Entities;

namespace esewa_market.Data.Dto.Response;

public class UserAddressResponse
{
    public int Id { get; set; }

    public string FullName { get; set; } = "";

    public string PhoneNumber { get; set; } = "";

    public string FullAddress { get; set; } = "";

    public AddressLabel Label { get; set; }

    public bool IsDefaultAddress { get; set; }

    public bool IsDefaultShippingAddress { get; set; }
}