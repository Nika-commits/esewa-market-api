using esewa_market.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace esewa_market.Data;

public static class DataSeeder
{
    public static async Task Seed(IServiceProvider serviceProvider)
    {
        var db = serviceProvider.GetRequiredService<AppDbContext>();

        await SeedProducts(db);
        await SeedCategories(db);
    }

    private static async Task SeedProducts(AppDbContext db)
    {
        if (await db.Products.AnyAsync()) return;

        var products = new List<Product>{
            new()
            {
                Id = 1,
                Name = "50 T-Shirt",
                Price = 100,
                Description = "Product 1 Description",
                Brand = "Brand 1",
                Status = "In-Stock" ,
                ImageUrl = "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052841095"

            },
            new()
            {
                Id = 2,
                Name = "Nike Air Monarch",
                Price = 200,
                Description = "Product 2 Description",
                Brand ="Brand 2" ,
                Status = "Out-of-Stock",
                ImageUrl = "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/tshirt-blacknwhite-adiddydas/1770641109200"
            },
            new()
            {
                Id = 3,
                Name = "Dell Latitude 14",
                Price = 8200,
                Description = "Product 3 Description",
                Brand ="Brand 3",
                Status = "In-Stock",
                ImageUrl = "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679"

            },
            new()
            {
                Id = 4,
                Name = "Green Premium Hoodies",
                Price = 1200,
                Description = "Product 4 " +"Description",
                Brand ="Brand 4" ,
                Status = "Out-of-Stock",
                ImageUrl = "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621336359"},
            new()
            {
                Id = 5,
                Name = "Product 5",
                Price = 500,
                Description = "Product 5 Description",
                Brand ="Brand 5" ,
                Status = "In-Stock",
                ImageUrl = "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679"
            },
            };

        await db.Products.AddRangeAsync(products);
        await db.SaveChangesAsync();
    }

    private static async Task SeedCategories(AppDbContext db)
    {
        if(await db.Categories.AnyAsync()) return;

        var categories = new List<Category>
        {
            new() { Id = 1, Name = "Men" },
            new() { Id = 2, Name = "Women" },
            new() { Id = 3, Name = "Kids" },
        };
        await db.Categories.AddRangeAsync(categories);
        await db.SaveChangesAsync();
    }


}