using esewa_market.Data.Entities;

namespace esewa_market.Data.Dto.Request;

public class CreateAddressRequest
{
    public string FullName { get; set; } = "";

    public string PhoneNumber { get; set; } = "";

    public string FullAddress { get; set; } = "";

    public AddressLabel Label { get; set; } = AddressLabel.Home;

    public bool IsDefaultAddress { get; set; } = false;

    public bool IsDefaultShippingAddress { get; set; } = false;
}