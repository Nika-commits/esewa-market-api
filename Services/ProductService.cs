using esewa_market.Data;
using esewa_market.Data.Entities;
using esewa_market.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace esewa_market.Services;

public class ProductService(AppDbContext db) : IProductService
{

    public async Task<List<Product>> GetFeaturedProducts(string? category)
    {
        IQueryable<Product> products = db.Products;

        if (!string.IsNullOrWhiteSpace(category) && category == "featured")
        {
            products = products.Where(p => p.IsFeatured == true);
        }
        return await products.ToListAsync();
    }

    public async Task<Product?> GetProductById(int id)
    {

        var product = await db.Products.FirstOrDefaultAsync(p => p.Id == id);
        return product;
    }
}