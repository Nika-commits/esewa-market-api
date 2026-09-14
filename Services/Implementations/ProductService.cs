using esewa_market.Data;
using esewa_market.Data.Entities;
using esewa_market.Data.Enums;
using esewa_market.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace esewa_market.Services.Implementations;

public class ProductService(
    AppDbContext db,
    ILogger<ProductService> logger) : IProductService
{

    public async Task<List<Product>> GetProducts(string? category, string? search,
        PriceFilter priceFilter, int page, int pageSize)
    {
        IQueryable<Product> products = db.Products;

        logger.LogInformation(
            "Getting products with category: {category}, search: {search}, filter: {priceFilter} page: " +
            "{page}," +
            " pageSize: {pageSize}",
            category, search, priceFilter, page, pageSize);

        if (!string.IsNullOrWhiteSpace(category) && category == "featured")
        {
            products = products.Where(p => p.IsFeatured == true);
        }

        if (!string.IsNullOrWhiteSpace(search))
        {
            products = products.Where(p =>
                EF.Functions.ILike(p.Name, $"%{search}%") ||
                EF.Functions.ILike(p.Description, $"%{search}%"));
        }

        products = priceFilter switch
        {
            PriceFilter.BestSellers => products.OrderBy(p => p.Name),
            PriceFilter.PriceHighToLow => products.OrderByDescending(p => p.Price),
            PriceFilter.PriceLowToHigh => products.OrderBy(p => p.Price),
            _ => products.OrderBy(p => p.Id)
        };

        return await products
            .Skip(page * pageSize)
            .Take(pageSize)
            .ToListAsync();
        throw new NotImplementedException();
    }

    public async Task<Product?> GetProductById(int id)
    {
        var product = await db.Products.FirstOrDefaultAsync(p => p.Id == id);
        return product;
    }

    public async Task<List<string>> GetSearchSuggestions(string query)
    {
        logger.LogInformation("Searching for products with query: {query}", query);
        return await db.Products
            .Where(p => EF.Functions.ILike(p.Name, $"%{query}%"))
            .OrderBy(p => p.Name)
            .Select(p => p.Name)
            .Take(15)
            .ToListAsync();
    }
}