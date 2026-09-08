namespace esewa_market.Services.Interfaces;

public interface IKhaltiService
{
    Task<string> InitiatePayment(decimal amount);
    Task<string> LookupPayment(string transactionId);
}