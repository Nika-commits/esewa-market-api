using esewa_market.Data.Entities;

namespace esewa_market.Services.Interfaces;

public interface IProductService
{
    Task<List<Product>> GetProducts(string? category, int page, int pageSize);
    Task<Product?> GetProductById(int id);
}