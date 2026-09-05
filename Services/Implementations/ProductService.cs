using esewa_market.Data;
using esewa_market.Data.Entities;
using esewa_market.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace esewa_market.Services.Implementations;

public class ProductService(AppDbContext db) : IProductService
{

    public async Task<List<Product>> GetProducts(string? category, int page, int pageSize)
    {
        IQueryable<Product> products = db.Products;

        if (!string.IsNullOrWhiteSpace(category) && category == "featured")
        {
            products = products.Where(p => p.IsFeatured == true);
        }

        return await products
            .OrderBy(p => p.Id)
            .Skip(page * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<Product?> GetProductById(int id)
    {
        var product = await db.Products.FirstOrDefaultAsync(p => p.Id == id);
        return product;
    }

    public async Task<List<string>> GetSearchSuggestions(string query)
    {
        return await db.Products
            .Where(p => EF.Functions.ILike(p.Name, $"%{query}%"))
            .OrderBy(p => p.Name)
            .Select(p => p.Name)
            .Take(10)
            .ToListAsync();
    }
}