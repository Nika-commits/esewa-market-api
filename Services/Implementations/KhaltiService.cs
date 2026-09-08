using esewa_market.Data;
using esewa_market.Data.Dto.Request;
using esewa_market.Services.Interfaces;

namespace esewa_market.Services.Implementations;

public class KhaltiService(
    AppDbContext db
) : IKhaltiService
{

    public async Task<string> InitiatePayment(CreateKhaltiPayment request)
    {
        var url = "https://dev.khalti.com/api/v2/epayment/initiate/";
        throw new NotImplementedException();
    }

    public async Task<string> LookupPayment(string transactionId)
    {
        throw new NotImplementedException();
    }
}