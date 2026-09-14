using esewa_market.Data.Entities;
using esewa_market.Data.Enums;

namespace esewa_market.Services.Interfaces;

public interface IProductService
{
    Task<List<Product>> GetProducts(
        string? category,
        string? search,
        PriceFilter priceFilter,
        int page,
        int pageSize);

    Task<Product?> GetProductById(int id);
    Task<List<string>> GetSearchSuggestions(string query);
}