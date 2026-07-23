using esewa_market.Data.Entities;

namespace esewa_market.Services.Interfaces;

public interface IProductService
{
    Task<List<Product>> GetFeaturedProducts(string? category);
    Task<Product?> GetProductById(int id);
}