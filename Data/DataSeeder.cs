using esewa_market.Data.Entities;
using esewa_market.Data.Enums;
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
                Description = """
                              <h3>Product Details</h3>
                              <p>A comfortable everyday t-shirt made from soft cotton fabric. Designed for casual wear with a modern fit.</p>

                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck:</strong> Crew Neck</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Brand 1",
                Status = "In-Stock" ,
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052841095",
                    "https://gqtuuqsgkyffgcpbfltk.supabase" +
                    ".co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841200",
                    "https://gqtuuqsgkyffgcpbfltk.supabase" +
                    ".co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231",
                ],
                Colors =
                [
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF"),
                    new("Green", "#00FF00"),
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB"),
                    new("Brown", "#A52A2A"),
                    new("Black", "#000000"),
                    new("White", "#FFFFFF")
                ],
                Sizes = [
                    "L",
                    "XL",
                    "XXL"
                ]

            },
            new()
            {
                Id = 2,
                Name = "Nike Air Monarch",
                Price = 200,
                Description = """
                              <h3>Product Details</h3>
                              <p>The Nike Air Monarch delivers excellent comfort and cushioning for everyday walking and training.</p>

                              <ul>
                                  <li><strong>Upper:</strong> Synthetic Leather</li>
                                  <li><strong>Sole:</strong> Durable Rubber</li>
                                  <li><strong>Support:</strong> Air Cushioning</li>
                                  <li><strong>Closure:</strong> Lace-Up</li>
                              </ul>

                              <p>Built for all-day comfort with reliable grip and support.</p>
                              """,
                Brand ="Brand 2" ,
                Status = "Out-of-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/tshirt-blacknwhite-adiddydas/1770641109200",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/summer-setttt-ssss/1780819572953"
                ],
                Colors =
                [
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF"),
                    new("Green", "#00FF00"),
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB"),
                    new("Brown", "#A52A2A"),
                    new("Black", "#000000"),
                    new("White", "#FFFFFF")
                ],
                Sizes = [
                    "L",
                    "XL",
                    "XXL"
                ]
            },
            new()
            {
                Id = 3,
                Name = "Dell Latitude 14",
                Price = 8200,
                Description = """
                              <h3>Product Details</h3>
                              <p>A reliable business laptop designed for productivity, multitasking, and professional workloads.</p>

                              <ul>
                                  <li><strong>Display:</strong> 14-inch Full HD</li>
                                  <li><strong>Processor:</strong> Intel Core Series</li>
                                  <li><strong>Storage:</strong> SSD</li>
                                  <li><strong>Ideal For:</strong> Office, Study, and Development</li>
                              </ul>

                              <p>Lightweight, durable, and suitable for everyday computing.</p>
                              """,
                Brand ="Brand 3",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/sweatshirt-puma/1770641194945"
                ],
                Colors =
                [
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF"),
                    new("Green", "#00FF00"),
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB"),
                    new("Brown", "#A52A2A"),
                    new("Black", "#000000"),
                    new("White", "#FFFFFF")
                ],
                Sizes = [
                    "L",
                    "XL",
                    "XXL"
                ]

            },
            new()
            {
                Id = 4,
                Name = "Green Premium Hoodies",
                Price = 1200,
                Description = """
                              <h3>Product Details</h3>
                              <p>Stay warm with this premium hoodie crafted from soft fleece fabric for maximum comfort.</p>

                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend</li>
                                  <li><strong>Fit:</strong> Relaxed Fit</li>
                                  <li><strong>Features:</strong> Hood with Drawstrings</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Perfect for cool weather and everyday casual outfits.</p>
                              """,
                Brand ="Brand 4" ,
                Status = "Out-of-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621336359",
                ],
                Colors =
                [
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF"),
                    new("Green", "#00FF00"),
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB"),
                    new("Brown", "#A52A2A"),
                    new("Black", "#000000"),
                    new("White", "#FFFFFF")
                ],
                Sizes = [
                    "L",
                    "XL",
                    "XXL"
                ]
            },

            new()
            {
                Id = 5,
                Name = "Translucent Shirt",
                Price = 500,
                Description = """
                              <h3>Product Details</h3>
                              <p>A stylish translucent shirt featuring a lightweight fabric and contemporary design for a standout look.</p>

                              <ul>
                                  <li><strong>Material:</strong> Lightweight Polyester Blend</li>
                                  <li><strong>Fit:</strong> Oversized</li>
                                  <li><strong>Sleeves:</strong> Long Sleeve</li>
                                  <li><strong>Style:</strong> Modern Casual</li>
                              </ul>

                              <p>Ideal for layering and creating fashionable streetwear outfits.</p>
                              """,
                Brand ="Brand 5" ,
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621602013",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621604147"
                ],
                Colors =
                [
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF"),
                    new("Green", "#00FF00"),
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB"),
                    new("Brown", "#A52A2A"),
                    new("Black", "#000000"),
                    new("White", "#FFFFFF")
                ],
                Sizes = [
                    "L",
                    "XL",
                    "XXL"
                ]
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