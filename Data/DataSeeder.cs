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
                              <ul>
                                  <li><strong>✅</strong> 100% Cotton</li>
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
                ],
                IsFeatured = true

            },
            new()
            {
                Id = 2,
                Name = "Nike Air Monarch",
                Price = 200,
                Description = """
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
                ],
                IsFeatured = true
            },
            new()
            {
                Id = 3,
                Name = "Dell Latitude 14",
                Price = 8200,
                Description = """
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
                ],
                IsFeatured = true

            },
            new()
            {
                Id = 4,
                Name = "Green Premium Hoodies",
                Price = 1200,
                Description = """
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
                ],
                IsFeatured = true
            },
            new()
            {
                Id = 5,
                Name = "Translucent Shirt",
                Price = 500,
                Description = """
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
                ],
            },
      new()
{
    Id = 6,
    Name = "Classic Black T-Shirt",
    Price = 650,
    Description = """
                  <ul>
                      <li><strong>Material:</strong> 100% Cotton</li>
                      <li><strong>Fit:</strong> Regular Fit</li>
                      <li><strong>Neck:</strong> Crew Neck</li>
                      <li><strong>Style:</strong> Everyday Casual</li>
                  </ul>

                  <p>A simple everyday t-shirt suitable for casual outfits.</p>
                  """,
    Brand = "Adiddydas",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/tshirt-blacknwhite-adiddydas/1770641109200"
    ],
    Colors =
    [
        new("Black", "#000000"),
        new("White", "#FFFFFF"),
        new("Grey", "#808080")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL",
        "XXL"
    ],
},
new()
{
    Id = 7,
    Name = "Red Streetwear Hoodie",
    Price = 1800,
    Description = """
                  <ul>
                      <li><strong>Material:</strong> Cotton Blend</li>
                      <li><strong>Fit:</strong> Oversized</li>
                      <li><strong>Features:</strong> Adjustable Hood</li>
                      <li><strong>Pocket:</strong> Kangaroo Pocket</li>
                  </ul>

                  <p>A comfortable oversized hoodie designed for casual streetwear.</p>
                  """,
    Brand = "Adiddydas",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase" +
        ".co/storage/v1/object/public/product-images/orange-sweater-celine/1770641861684",
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679"
    ],
    Colors =
    [
        new("Red", "#FF0000"),
        new("Black", "#000000"),
        new("White", "#FFFFFF")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL"
    ],
},
new()
{
    Id = 8,
    Name = "Puma Casual Sweatshirt",
    Price = 1450,
    Description = """
                  <ul>
                      <li><strong>Material:</strong> Cotton Fleece</li>
                      <li><strong>Fit:</strong> Relaxed Fit</li>
                      <li><strong>Sleeves:</strong> Long Sleeve</li>
                      <li><strong>Style:</strong> Casual Sportswear</li>
                  </ul>

                  <p>A soft sweatshirt suitable for casual and everyday wear.</p>
                  """,
    Brand = "Puma",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/simple-flat-i-heart-you-valentine's-day-t-shirt-puma/1770642082740"
    ],
    Colors =
    [
        new("Grey", "#808080"),
        new("Black", "#000000"),
        new("Blue", "#0000FF")
    ],
    Sizes =
    [
        "S",
        "M",
        "L",
        "XL"
    ],
},
new()
{
    Id = 9,
    Name = "White Oxford Shirt",
    Price = 1250,
    Description = """
                  <ul>
                      <li><strong>Material:</strong> Oxford Cotton</li>
                      <li><strong>Fit:</strong> Regular Fit</li>
                      <li><strong>Collar:</strong> Button Down</li>
                      <li><strong>Style:</strong> Smart Casual</li>
                  </ul>

                  <p>A versatile Oxford shirt suitable for office and casual occasions.</p>
                  """,
    Brand = "Oxford",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase" +
        ".co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621604147",
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621604147"
    ],
    Colors =
    [
        new("White", "#FFFFFF"),
        new("Blue", "#ADD8E6")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL",
        "XXL"
    ],
},
new()
{
    Id = 10,
    Name = "MNML Geo Shorts",
    Price = 1100,
    Description = """
                  <ul>
                      <li><strong>Material:</strong> Cotton Blend</li>
                      <li><strong>Fit:</strong> Relaxed Fit</li>
                      <li><strong>Pockets:</strong> Front Utility Pockets</li>
                      <li><strong>Style:</strong> Streetwear</li>
                  </ul>

                  <p>Comfortable shorts designed for casual summer outfits.</p>
                  """,
    Brand = "MNML",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621839642",
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231"
    ],
    Colors =
    [
        new("Black", "#000000"),
        new("Brown", "#A52A2A"),
        new("Grey", "#808080")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL"
    ],
},
new()
{
    Id = 11,
    Name = "Affirmation Oversized Hoodie",
    Price = 2100,
    Description = """
                  <ul>
                      <li><strong>Material:</strong> Heavyweight Cotton</li>
                      <li><strong>Fit:</strong> Oversized</li>
                      <li><strong>Hood:</strong> Double Layered</li>
                      <li><strong>Style:</strong> Premium Streetwear</li>
                  </ul>

                  <p>A heavyweight hoodie designed for colder weather and streetwear styling.</p>
                  """,
    Brand = "Affirmation",
    Status = "Out-of-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase" +
        ".co/storage/v1/object/public/product-images/hoodie-puma/1770640995662",
        "https://gqtuuqsgkyffgcpbfltk.supabase" +
        ".co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338173",
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338156"
    ],
    Colors =
    [
        new("Black", "#000000"),
        new("Green", "#008000"),
        new("Brown", "#A52A2A")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL"
    ],
},
new()
{
    Id = 12,
    Name = "Summer Casual Set",
    Price = 1750,
    Description = """
                  <ul>
                      <li><strong>Material:</strong> Lightweight Cotton Blend</li>
                      <li><strong>Pieces:</strong> Shirt and Shorts</li>
                      <li><strong>Fit:</strong> Relaxed Fit</li>
                      <li><strong>Season:</strong> Summer</li>
                  </ul>

                  <p>A lightweight matching set designed for warm weather.</p>
                  """,
    Brand = "Summer Studio",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase" +
        ".co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052840379",
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052838239"
    ],
    Colors =
    [
        new("White", "#FFFFFF"),
        new("Beige", "#F5F5DC"),
        new("Black", "#000000")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL"
    ],
},
new()
{
    Id = 13,
    Name = "AEL Studio Translucent Shirt",
    Price = 950,
    Description = """
                  <ul>
                      <li><strong>Material:</strong> Polyester Blend</li>
                      <li><strong>Fit:</strong> Oversized</li>
                      <li><strong>Texture:</strong> Lightweight Translucent Fabric</li>
                      <li><strong>Style:</strong> Contemporary Streetwear</li>
                  </ul>

                  <p>A lightweight statement shirt suitable for layered outfits.</p>
                  """,
    Brand = "AEL Studio",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/shirt-with-green-embroidery-and-plant-no-brand/1770641959695"
    ],
    Colors =
    [
        new("White", "#FFFFFF"),
        new("Black", "#000000"),
        new("Grey", "#808080")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL"
    ],
},
new()
{
    Id = 14,
    Name = "Essential Everyday Hoodie",
    Price = 1600,
    Description = """
                  <ul>
                      <li><strong>Material:</strong> Cotton Fleece</li>
                      <li><strong>Fit:</strong> Regular Fit</li>
                      <li><strong>Features:</strong> Ribbed Cuffs</li>
                      <li><strong>Season:</strong> Autumn and Winter</li>
                  </ul>

                  <p>A versatile everyday hoodie designed for comfort and warmth.</p>
                  """,
    Brand = "Essential",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/hoodie-puma/1770640995662",
    ],
    Colors =
    [
        new("Red", "#FF0000"),
        new("Black", "#000000"),
        new("Green", "#008000")
    ],
    Sizes =
    [
        "S",
        "M",
        "L",
        "XL",
        "XXL"
    ],
},
new()
{
    Id = 15,
    Name = "Premium Streetwear Combo",
    Price = 2500,
    Description = """
                  <ul>
                      <li><strong>Material:</strong> Premium Cotton Blend</li>
                      <li><strong>Fit:</strong> Relaxed Fit</li>
                      <li><strong>Style:</strong> Modern Streetwear</li>
                      <li><strong>Use:</strong> Casual and Travel</li>
                  </ul>

                  <p>A premium casual outfit designed for comfortable everyday wear.</p>
                  """,
    Brand = "Urban Collection",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819797027",
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819796759"
    ],
    Colors =
    [
        new("Black", "#000000"),
        new("White", "#FFFFFF"),
        new("Brown", "#A52A2A")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL",
        "XXL"
    ],
},
new()
{
    Id = 16,
    Name = "Urban Cotton T-Shirt",
    Price = 642,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> 100% Cotton</li>
                       <li><strong>Fit:</strong> Regular Fit</li>
                       <li><strong>Features:</strong> Crew Neck</li>
                       <li><strong>Style:</strong> Everyday Casual</li>
                  </ul>

                   <p>A comfortable t-shirt suitable for daily wear and casual outfits.</p>
                  """,
    Brand = "Urban Collection",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052840379"
    ],
    Colors =
    [
        new("Black", "#000000"),
        new("White", "#FFFFFF"),
        new("Grey", "#808080")
    ],
    Sizes =
    [
        "S",
        "M",
        "L",
        "XL"
    ],
    IsFeatured = false
},
new()
{
    Id = 17,
    Name = "Classic Oversized Tee",
    Price = 779,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> 100% Cotton</li>
                       <li><strong>Fit:</strong> Regular Fit</li>
                       <li><strong>Features:</strong> Crew Neck</li>
                       <li><strong>Style:</strong> Everyday Casual</li>
                  </ul>

                   <p>A comfortable t-shirt suitable for daily wear and casual outfits.</p>
                  """,
    Brand = "Essential",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052838239"
    ],
    Colors =
    [
        new("Red", "#FF0000"),
        new("Black", "#000000"),
        new("White", "#FFFFFF")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL"
    ],
    IsFeatured = false
},
new()
{
    Id = 18,
    Name = "Essential Crew Neck T-Shirt",
    Price = 916,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> 100% Cotton</li>
                       <li><strong>Fit:</strong> Regular Fit</li>
                       <li><strong>Features:</strong> Crew Neck</li>
                       <li><strong>Style:</strong> Everyday Casual</li>
                  </ul>

                   <p>A comfortable t-shirt suitable for daily wear and casual outfits.</p>
                  """,
    Brand = "AEL Studio",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/shirt-with-green-embroidery-and-plant-no-brand/1770641959695",
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231"
    ],
    Colors =
    [
        new("Blue", "#0000FF"),
        new("White", "#FFFFFF"),
        new("Black", "#000000")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL",
        "XXL"
    ],
    IsFeatured = false
},
new()
{
    Id = 19,
    Name = "Relaxed Street T-Shirt",
    Price = 1053,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> 100% Cotton</li>
                       <li><strong>Fit:</strong> Regular Fit</li>
                       <li><strong>Features:</strong> Crew Neck</li>
                       <li><strong>Style:</strong> Everyday Casual</li>
                  </ul>

                   <p>A comfortable t-shirt suitable for daily wear and casual outfits.</p>
                  """,
    Brand = "MNML",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819797027"
    ],
    Colors =
    [
        new("Green", "#008000"),
        new("Black", "#000000"),
        new("Brown", "#A52A2A")
    ],
    Sizes =
    [
        "S",
        "M",
        "L",
        "XL",
        "XXL"
    ],
    IsFeatured = false
},
new()
{
    Id = 20,
    Name = "Premium Everyday Tee",
    Price = 1190,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> 100% Cotton</li>
                       <li><strong>Fit:</strong> Regular Fit</li>
                       <li><strong>Features:</strong> Crew Neck</li>
                       <li><strong>Style:</strong> Everyday Casual</li>
                  </ul>

                   <p>A comfortable t-shirt suitable for daily wear and casual outfits.</p>
                  """,
    Brand = "Puma",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819796759"
    ],
    Colors =
    [
        new("Beige", "#F5F5DC"),
        new("White", "#FFFFFF"),
        new("Brown", "#A52A2A")
    ],
    Sizes =
    [
        "S",
        "M",
        "L",
        "XL"
    ],
    IsFeatured = true
},
new()
{
    Id = 21,
    Name = "Vintage Graphic T-Shirt",
    Price = 1327,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> 100% Cotton</li>
                       <li><strong>Fit:</strong> Regular Fit</li>
                       <li><strong>Features:</strong> Crew Neck</li>
                       <li><strong>Style:</strong> Everyday Casual</li>
                  </ul>

                   <p>A comfortable t-shirt suitable for daily wear and casual outfits.</p>
                  """,
    Brand = "Adiddydas",
    Status = "Out-of-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052841095",
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679"
    ],
    Colors =
    [
        new("Black", "#000000"),
        new("White", "#FFFFFF"),
        new("Grey", "#808080")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL"
    ],
    IsFeatured = false
},
new()
{
    Id = 22,
    Name = "Minimal Black T-Shirt",
    Price = 1464,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> 100% Cotton</li>
                       <li><strong>Fit:</strong> Regular Fit</li>
                       <li><strong>Features:</strong> Crew Neck</li>
                       <li><strong>Style:</strong> Everyday Casual</li>
                  </ul>

                   <p>A comfortable t-shirt suitable for daily wear and casual outfits.</p>
                  """,
    Brand = "Oxford",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841200"
    ],
    Colors =
    [
        new("Red", "#FF0000"),
        new("Black", "#000000"),
        new("White", "#FFFFFF")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL",
        "XXL"
    ],
    IsFeatured = false
},
new()
{
    Id = 23,
    Name = "Soft Cotton Basic Tee",
    Price = 1601,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> 100% Cotton</li>
                       <li><strong>Fit:</strong> Regular Fit</li>
                       <li><strong>Features:</strong> Crew Neck</li>
                       <li><strong>Style:</strong> Everyday Casual</li>
                  </ul>

                   <p>A comfortable t-shirt suitable for daily wear and casual outfits.</p>
                  """,
    Brand = "Summer Studio",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231"
    ],
    Colors =
    [
        new("Blue", "#0000FF"),
        new("White", "#FFFFFF"),
        new("Black", "#000000")
    ],
    Sizes =
    [
        "S",
        "M",
        "L",
        "XL",
        "XXL"
    ],
    IsFeatured = false
},
new()
{
    Id = 24,
    Name = "Weekend Casual T-Shirt",
    Price = 1738,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> 100% Cotton</li>
                       <li><strong>Fit:</strong> Regular Fit</li>
                       <li><strong>Features:</strong> Crew Neck</li>
                       <li><strong>Style:</strong> Everyday Casual</li>
                  </ul>

                   <p>A comfortable t-shirt suitable for daily wear and casual outfits.</p>
                  """,
    Brand = "Affirmation",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/tshirt-blacknwhite-adiddydas/1770641109200",
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621602013"
    ],
    Colors =
    [
        new("Green", "#008000"),
        new("Black", "#000000"),
        new("Brown", "#A52A2A")
    ],
    Sizes =
    [
        "S",
        "M",
        "L",
        "XL"
    ],
    IsFeatured = false
},
new()
{
    Id = 25,
    Name = "Core White T-Shirt",
    Price = 1875,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> 100% Cotton</li>
                       <li><strong>Fit:</strong> Regular Fit</li>
                       <li><strong>Features:</strong> Crew Neck</li>
                       <li><strong>Style:</strong> Everyday Casual</li>
                  </ul>

                   <p>A comfortable t-shirt suitable for daily wear and casual outfits.</p>
                  """,
    Brand = "Core Studio",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/summer-setttt-ssss/1780819572953"
    ],
    Colors =
    [
        new("Beige", "#F5F5DC"),
        new("White", "#FFFFFF"),
        new("Brown", "#A52A2A")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL"
    ],
    IsFeatured = true
},
new()
{
    Id = 26,
    Name = "Urban Pullover Hoodie",
    Price = 2012,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Fleece</li>
                       <li><strong>Fit:</strong> Relaxed Fit</li>
                       <li><strong>Features:</strong> Adjustable Hood</li>
                       <li><strong>Style:</strong> Casual Streetwear</li>
                  </ul>

                   <p>A comfortable hoodie designed for everyday casual wear.</p>
                  """,
    Brand = "Urban Collection",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679"
    ],
    Colors =
    [
        new("Black", "#000000"),
        new("White", "#FFFFFF"),
        new("Grey", "#808080")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL",
        "XXL"
    ],
    IsFeatured = false
},
new()
{
    Id = 27,
    Name = "Classic Fleece Hoodie",
    Price = 2149,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Fleece</li>
                       <li><strong>Fit:</strong> Relaxed Fit</li>
                       <li><strong>Features:</strong> Adjustable Hood</li>
                       <li><strong>Style:</strong> Casual Streetwear</li>
                  </ul>

                   <p>A comfortable hoodie designed for everyday casual wear.</p>
                  """,
    Brand = "Essential",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/sweatshirt-puma/1770641194945",
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/simple-flat-i-heart-you-valentine's-day-t-shirt-puma/1770642082740"
    ],
    Colors =
    [
        new("Red", "#FF0000"),
        new("Black", "#000000"),
        new("White", "#FFFFFF")
    ],
    Sizes =
    [
        "S",
        "M",
        "L",
        "XL",
        "XXL"
    ],
    IsFeatured = false
},
new()
{
    Id = 28,
    Name = "Essential Oversized Hoodie",
    Price = 2286,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Fleece</li>
                       <li><strong>Fit:</strong> Relaxed Fit</li>
                       <li><strong>Features:</strong> Adjustable Hood</li>
                       <li><strong>Style:</strong> Casual Streetwear</li>
                  </ul>

                   <p>A comfortable hoodie designed for everyday casual wear.</p>
                  """,
    Brand = "AEL Studio",
    Status = "Out-of-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621336359"
    ],
    Colors =
    [
        new("Blue", "#0000FF"),
        new("White", "#FFFFFF"),
        new("Black", "#000000")
    ],
    Sizes =
    [
        "S",
        "M",
        "L",
        "XL"
    ],
    IsFeatured = false
},
new()
{
    Id = 29,
    Name = "Streetwear Graphic Hoodie",
    Price = 2423,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Fleece</li>
                       <li><strong>Fit:</strong> Relaxed Fit</li>
                       <li><strong>Features:</strong> Adjustable Hood</li>
                       <li><strong>Style:</strong> Casual Streetwear</li>
                  </ul>

                   <p>A comfortable hoodie designed for everyday casual wear.</p>
                  """,
    Brand = "MNML",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621602013"
    ],
    Colors =
    [
        new("Green", "#008000"),
        new("Black", "#000000"),
        new("Brown", "#A52A2A")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL"
    ],
    IsFeatured = false
},
new()
{
    Id = 30,
    Name = "Everyday Comfort Hoodie",
    Price = 2560,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Fleece</li>
                       <li><strong>Fit:</strong> Relaxed Fit</li>
                       <li><strong>Features:</strong> Adjustable Hood</li>
                       <li><strong>Style:</strong> Casual Streetwear</li>
                  </ul>

                   <p>A comfortable hoodie designed for everyday casual wear.</p>
                  """,
    Brand = "Puma",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621604147",
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338173"
    ],
    Colors =
    [
        new("Beige", "#F5F5DC"),
        new("White", "#FFFFFF"),
        new("Brown", "#A52A2A")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL",
        "XXL"
    ],
    IsFeatured = true
},
new()
{
    Id = 31,
    Name = "Heavyweight Winter Hoodie",
    Price = 597,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Fleece</li>
                       <li><strong>Fit:</strong> Relaxed Fit</li>
                       <li><strong>Features:</strong> Adjustable Hood</li>
                       <li><strong>Style:</strong> Casual Streetwear</li>
                  </ul>

                   <p>A comfortable hoodie designed for everyday casual wear.</p>
                  """,
    Brand = "Adiddydas",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/orange-sweater-celine/1770641861684"
    ],
    Colors =
    [
        new("Black", "#000000"),
        new("White", "#FFFFFF"),
        new("Grey", "#808080")
    ],
    Sizes =
    [
        "S",
        "M",
        "L",
        "XL",
        "XXL"
    ],
    IsFeatured = false
},
new()
{
    Id = 32,
    Name = "Relaxed Fit Hoodie",
    Price = 734,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Fleece</li>
                       <li><strong>Fit:</strong> Relaxed Fit</li>
                       <li><strong>Features:</strong> Adjustable Hood</li>
                       <li><strong>Style:</strong> Casual Streetwear</li>
                  </ul>

                   <p>A comfortable hoodie designed for everyday casual wear.</p>
                  """,
    Brand = "Oxford",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/simple-flat-i-heart-you-valentine's-day-t-shirt-puma/1770642082740"
    ],
    Colors =
    [
        new("Red", "#FF0000"),
        new("Black", "#000000"),
        new("White", "#FFFFFF")
    ],
    Sizes =
    [
        "S",
        "M",
        "L",
        "XL"
    ],
    IsFeatured = false
},
new()
{
    Id = 33,
    Name = "Premium Cotton Hoodie",
    Price = 871,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Fleece</li>
                       <li><strong>Fit:</strong> Relaxed Fit</li>
                       <li><strong>Features:</strong> Adjustable Hood</li>
                       <li><strong>Style:</strong> Casual Streetwear</li>
                  </ul>

                   <p>A comfortable hoodie designed for everyday casual wear.</p>
                  """,
    Brand = "Summer Studio",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621839642",
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052838239"
    ],
    Colors =
    [
        new("Blue", "#0000FF"),
        new("White", "#FFFFFF"),
        new("Black", "#000000")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL"
    ],
    IsFeatured = false
},
new()
{
    Id = 34,
    Name = "Minimal Zip Hoodie",
    Price = 1008,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Fleece</li>
                       <li><strong>Fit:</strong> Relaxed Fit</li>
                       <li><strong>Features:</strong> Adjustable Hood</li>
                       <li><strong>Style:</strong> Casual Streetwear</li>
                  </ul>

                   <p>A comfortable hoodie designed for everyday casual wear.</p>
                  """,
    Brand = "Affirmation",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/hoodie-puma/1770640995662"
    ],
    Colors =
    [
        new("Green", "#008000"),
        new("Black", "#000000"),
        new("Brown", "#A52A2A")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL",
        "XXL"
    ],
    IsFeatured = false
},
new()
{
    Id = 35,
    Name = "Urban Layer Hoodie",
    Price = 1145,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Fleece</li>
                       <li><strong>Fit:</strong> Relaxed Fit</li>
                       <li><strong>Features:</strong> Adjustable Hood</li>
                       <li><strong>Style:</strong> Casual Streetwear</li>
                  </ul>

                   <p>A comfortable hoodie designed for everyday casual wear.</p>
                  """,
    Brand = "Core Studio",
    Status = "Out-of-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338173"
    ],
    Colors =
    [
        new("Beige", "#F5F5DC"),
        new("White", "#FFFFFF"),
        new("Brown", "#A52A2A")
    ],
    Sizes =
    [
        "S",
        "M",
        "L",
        "XL",
        "XXL"
    ],
    IsFeatured = true
},
new()
{
    Id = 36,
    Name = "Classic Casual Sweatshirt",
    Price = 1282,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Fleece</li>
                       <li><strong>Fit:</strong> Regular Fit</li>
                       <li><strong>Features:</strong> Long Sleeve</li>
                       <li><strong>Style:</strong> Casual Sportswear</li>
                  </ul>

                   <p>A soft sweatshirt suitable for everyday outfits and cooler weather.</p>
                  """,
    Brand = "Urban Collection",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338156",
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819796759"
    ],
    Colors =
    [
        new("Black", "#000000"),
        new("White", "#FFFFFF"),
        new("Grey", "#808080")
    ],
    Sizes =
    [
        "S",
        "M",
        "L",
        "XL"
    ],
    IsFeatured = false
},
new()
{
    Id = 37,
    Name = "Relaxed Fleece Sweatshirt",
    Price = 1419,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Fleece</li>
                       <li><strong>Fit:</strong> Regular Fit</li>
                       <li><strong>Features:</strong> Long Sleeve</li>
                       <li><strong>Style:</strong> Casual Sportswear</li>
                  </ul>

                   <p>A soft sweatshirt suitable for everyday outfits and cooler weather.</p>
                  """,
    Brand = "Essential",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052840379"
    ],
    Colors =
    [
        new("Red", "#FF0000"),
        new("Black", "#000000"),
        new("White", "#FFFFFF")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL"
    ],
    IsFeatured = false
},
new()
{
    Id = 38,
    Name = "Premium Crew Sweatshirt",
    Price = 1556,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Fleece</li>
                       <li><strong>Fit:</strong> Regular Fit</li>
                       <li><strong>Features:</strong> Long Sleeve</li>
                       <li><strong>Style:</strong> Casual Sportswear</li>
                  </ul>

                   <p>A soft sweatshirt suitable for everyday outfits and cooler weather.</p>
                  """,
    Brand = "AEL Studio",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052838239"
    ],
    Colors =
    [
        new("Blue", "#0000FF"),
        new("White", "#FFFFFF"),
        new("Black", "#000000")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL",
        "XXL"
    ],
    IsFeatured = false
},
new()
{
    Id = 39,
    Name = "Everyday Pullover Sweatshirt",
    Price = 1693,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Fleece</li>
                       <li><strong>Fit:</strong> Regular Fit</li>
                       <li><strong>Features:</strong> Long Sleeve</li>
                       <li><strong>Style:</strong> Casual Sportswear</li>
                  </ul>

                   <p>A soft sweatshirt suitable for everyday outfits and cooler weather.</p>
                  """,
    Brand = "MNML",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/shirt-with-green-embroidery-and-plant-no-brand/1770641959695",
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231"
    ],
    Colors =
    [
        new("Green", "#008000"),
        new("Black", "#000000"),
        new("Brown", "#A52A2A")
    ],
    Sizes =
    [
        "S",
        "M",
        "L",
        "XL",
        "XXL"
    ],
    IsFeatured = false
},
new()
{
    Id = 40,
    Name = "Streetwear Cotton Sweatshirt",
    Price = 1830,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Fleece</li>
                       <li><strong>Fit:</strong> Regular Fit</li>
                       <li><strong>Features:</strong> Long Sleeve</li>
                       <li><strong>Style:</strong> Casual Sportswear</li>
                  </ul>

                   <p>A soft sweatshirt suitable for everyday outfits and cooler weather.</p>
                  """,
    Brand = "Puma",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819797027"
    ],
    Colors =
    [
        new("Beige", "#F5F5DC"),
        new("White", "#FFFFFF"),
        new("Brown", "#A52A2A")
    ],
    Sizes =
    [
        "S",
        "M",
        "L",
        "XL"
    ],
    IsFeatured = true
},
new()
{
    Id = 41,
    Name = "Oxford Everyday Shirt",
    Price = 1967,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Blend</li>
                       <li><strong>Fit:</strong> Regular Fit</li>
                       <li><strong>Features:</strong> Button Front</li>
                       <li><strong>Style:</strong> Smart Casual</li>
                  </ul>

                   <p>A versatile shirt suitable for casual, office, and weekend outfits.</p>
                  """,
    Brand = "Adiddydas",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819796759"
    ],
    Colors =
    [
        new("Black", "#000000"),
        new("White", "#FFFFFF"),
        new("Grey", "#808080")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL"
    ],
    IsFeatured = false
},
new()
{
    Id = 42,
    Name = "Relaxed Summer Shirt",
    Price = 2104,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Blend</li>
                       <li><strong>Fit:</strong> Regular Fit</li>
                       <li><strong>Features:</strong> Button Front</li>
                       <li><strong>Style:</strong> Smart Casual</li>
                  </ul>

                   <p>A versatile shirt suitable for casual, office, and weekend outfits.</p>
                  """,
    Brand = "Oxford",
    Status = "Out-of-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052841095",
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679"
    ],
    Colors =
    [
        new("Red", "#FF0000"),
        new("Black", "#000000"),
        new("White", "#FFFFFF")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL",
        "XXL"
    ],
    IsFeatured = false
},
new()
{
    Id = 43,
    Name = "Modern Oversized Shirt",
    Price = 2241,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Blend</li>
                       <li><strong>Fit:</strong> Regular Fit</li>
                       <li><strong>Features:</strong> Button Front</li>
                       <li><strong>Style:</strong> Smart Casual</li>
                  </ul>

                   <p>A versatile shirt suitable for casual, office, and weekend outfits.</p>
                  """,
    Brand = "Summer Studio",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841200"
    ],
    Colors =
    [
        new("Blue", "#0000FF"),
        new("White", "#FFFFFF"),
        new("Black", "#000000")
    ],
    Sizes =
    [
        "S",
        "M",
        "L",
        "XL",
        "XXL"
    ],
    IsFeatured = false
},
new()
{
    Id = 44,
    Name = "Classic Button Down Shirt",
    Price = 2378,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Blend</li>
                       <li><strong>Fit:</strong> Regular Fit</li>
                       <li><strong>Features:</strong> Button Front</li>
                       <li><strong>Style:</strong> Smart Casual</li>
                  </ul>

                   <p>A versatile shirt suitable for casual, office, and weekend outfits.</p>
                  """,
    Brand = "Affirmation",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231"
    ],
    Colors =
    [
        new("Green", "#008000"),
        new("Black", "#000000"),
        new("Brown", "#A52A2A")
    ],
    Sizes =
    [
        "S",
        "M",
        "L",
        "XL"
    ],
    IsFeatured = false
},
new()
{
    Id = 45,
    Name = "Lightweight Casual Shirt",
    Price = 2515,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Blend</li>
                       <li><strong>Fit:</strong> Regular Fit</li>
                       <li><strong>Features:</strong> Button Front</li>
                       <li><strong>Style:</strong> Smart Casual</li>
                  </ul>

                   <p>A versatile shirt suitable for casual, office, and weekend outfits.</p>
                  """,
    Brand = "Core Studio",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/tshirt-blacknwhite-adiddydas/1770641109200",
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621602013"
    ],
    Colors =
    [
        new("Beige", "#F5F5DC"),
        new("White", "#FFFFFF"),
        new("Brown", "#A52A2A")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL"
    ],
    IsFeatured = true
},
new()
{
    Id = 46,
    Name = "Premium Street Shirt",
    Price = 552,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Blend</li>
                       <li><strong>Fit:</strong> Regular Fit</li>
                       <li><strong>Features:</strong> Button Front</li>
                       <li><strong>Style:</strong> Smart Casual</li>
                  </ul>

                   <p>A versatile shirt suitable for casual, office, and weekend outfits.</p>
                  """,
    Brand = "Urban Collection",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/summer-setttt-ssss/1780819572953"
    ],
    Colors =
    [
        new("Black", "#000000"),
        new("White", "#FFFFFF"),
        new("Grey", "#808080")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL",
        "XXL"
    ],
    IsFeatured = false
},
new()
{
    Id = 47,
    Name = "Essential White Shirt",
    Price = 689,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Blend</li>
                       <li><strong>Fit:</strong> Regular Fit</li>
                       <li><strong>Features:</strong> Button Front</li>
                       <li><strong>Style:</strong> Smart Casual</li>
                  </ul>

                   <p>A versatile shirt suitable for casual, office, and weekend outfits.</p>
                  """,
    Brand = "Essential",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679"
    ],
    Colors =
    [
        new("Red", "#FF0000"),
        new("Black", "#000000"),
        new("White", "#FFFFFF")
    ],
    Sizes =
    [
        "S",
        "M",
        "L",
        "XL",
        "XXL"
    ],
    IsFeatured = false
},
new()
{
    Id = 48,
    Name = "Contemporary Layered Shirt",
    Price = 826,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Blend</li>
                       <li><strong>Fit:</strong> Regular Fit</li>
                       <li><strong>Features:</strong> Button Front</li>
                       <li><strong>Style:</strong> Smart Casual</li>
                  </ul>

                   <p>A versatile shirt suitable for casual, office, and weekend outfits.</p>
                  """,
    Brand = "AEL Studio",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/sweatshirt-puma/1770641194945",
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/simple-flat-i-heart-you-valentine's-day-t-shirt-puma/1770642082740"
    ],
    Colors =
    [
        new("Blue", "#0000FF"),
        new("White", "#FFFFFF"),
        new("Black", "#000000")
    ],
    Sizes =
    [
        "S",
        "M",
        "L",
        "XL"
    ],
    IsFeatured = false
},
new()
{
    Id = 49,
    Name = "Urban Embroidered Shirt",
    Price = 963,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Blend</li>
                       <li><strong>Fit:</strong> Regular Fit</li>
                       <li><strong>Features:</strong> Button Front</li>
                       <li><strong>Style:</strong> Smart Casual</li>
                  </ul>

                   <p>A versatile shirt suitable for casual, office, and weekend outfits.</p>
                  """,
    Brand = "MNML",
    Status = "Out-of-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621336359"
    ],
    Colors =
    [
        new("Green", "#008000"),
        new("Black", "#000000"),
        new("Brown", "#A52A2A")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL"
    ],
    IsFeatured = false
},
new()
{
    Id = 50,
    Name = "Weekend Resort Shirt",
    Price = 1100,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Blend</li>
                       <li><strong>Fit:</strong> Regular Fit</li>
                       <li><strong>Features:</strong> Button Front</li>
                       <li><strong>Style:</strong> Smart Casual</li>
                  </ul>

                   <p>A versatile shirt suitable for casual, office, and weekend outfits.</p>
                  """,
    Brand = "Puma",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621602013"
    ],
    Colors =
    [
        new("Beige", "#F5F5DC"),
        new("White", "#FFFFFF"),
        new("Brown", "#A52A2A")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL",
        "XXL"
    ],
    IsFeatured = true
},
new()
{
    Id = 51,
    Name = "Relaxed Utility Shorts",
    Price = 1237,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Blend</li>
                       <li><strong>Fit:</strong> Relaxed Fit</li>
                       <li><strong>Features:</strong> Utility Pockets</li>
                       <li><strong>Style:</strong> Summer Casual</li>
                  </ul>

                   <p>Comfortable shorts designed for warm weather and everyday wear.</p>
                  """,
    Brand = "Adiddydas",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621604147",
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338173"
    ],
    Colors =
    [
        new("Black", "#000000"),
        new("White", "#FFFFFF"),
        new("Grey", "#808080")
    ],
    Sizes =
    [
        "S",
        "M",
        "L",
        "XL",
        "XXL"
    ],
    IsFeatured = false
},
new()
{
    Id = 52,
    Name = "Everyday Cotton Shorts",
    Price = 1374,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Blend</li>
                       <li><strong>Fit:</strong> Relaxed Fit</li>
                       <li><strong>Features:</strong> Utility Pockets</li>
                       <li><strong>Style:</strong> Summer Casual</li>
                  </ul>

                   <p>Comfortable shorts designed for warm weather and everyday wear.</p>
                  """,
    Brand = "Oxford",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/orange-sweater-celine/1770641861684"
    ],
    Colors =
    [
        new("Red", "#FF0000"),
        new("Black", "#000000"),
        new("White", "#FFFFFF")
    ],
    Sizes =
    [
        "S",
        "M",
        "L",
        "XL"
    ],
    IsFeatured = false
},
new()
{
    Id = 53,
    Name = "Urban Streetwear Shorts",
    Price = 1511,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Blend</li>
                       <li><strong>Fit:</strong> Relaxed Fit</li>
                       <li><strong>Features:</strong> Utility Pockets</li>
                       <li><strong>Style:</strong> Summer Casual</li>
                  </ul>

                   <p>Comfortable shorts designed for warm weather and everyday wear.</p>
                  """,
    Brand = "Summer Studio",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/simple-flat-i-heart-you-valentine's-day-t-shirt-puma/1770642082740"
    ],
    Colors =
    [
        new("Blue", "#0000FF"),
        new("White", "#FFFFFF"),
        new("Black", "#000000")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL"
    ],
    IsFeatured = false
},
new()
{
    Id = 54,
    Name = "Summer Comfort Shorts",
    Price = 1648,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Blend</li>
                       <li><strong>Fit:</strong> Relaxed Fit</li>
                       <li><strong>Features:</strong> Utility Pockets</li>
                       <li><strong>Style:</strong> Summer Casual</li>
                  </ul>

                   <p>Comfortable shorts designed for warm weather and everyday wear.</p>
                  """,
    Brand = "Affirmation",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621839642",
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052838239"
    ],
    Colors =
    [
        new("Green", "#008000"),
        new("Black", "#000000"),
        new("Brown", "#A52A2A")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL",
        "XXL"
    ],
    IsFeatured = false
},
new()
{
    Id = 55,
    Name = "Premium Casual Shorts",
    Price = 1785,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Cotton Blend</li>
                       <li><strong>Fit:</strong> Relaxed Fit</li>
                       <li><strong>Features:</strong> Utility Pockets</li>
                       <li><strong>Style:</strong> Summer Casual</li>
                  </ul>

                   <p>Comfortable shorts designed for warm weather and everyday wear.</p>
                  """,
    Brand = "Core Studio",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/hoodie-puma/1770640995662"
    ],
    Colors =
    [
        new("Beige", "#F5F5DC"),
        new("White", "#FFFFFF"),
        new("Brown", "#A52A2A")
    ],
    Sizes =
    [
        "S",
        "M",
        "L",
        "XL",
        "XXL"
    ],
    IsFeatured = true
},
new()
{
    Id = 56,
    Name = "Classic Two Piece Set",
    Price = 1922,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Premium Cotton Blend</li>
                       <li><strong>Fit:</strong> Relaxed Fit</li>
                       <li><strong>Features:</strong> Two Piece Outfit</li>
                       <li><strong>Style:</strong> Modern Casual</li>
                  </ul>

                   <p>A coordinated casual outfit designed for comfort, travel, and everyday wear.</p>
                  """,
    Brand = "Urban Collection",
    Status = "Out-of-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338173"
    ],
    Colors =
    [
        new("Black", "#000000"),
        new("White", "#FFFFFF"),
        new("Grey", "#808080")
    ],
    Sizes =
    [
        "S",
        "M",
        "L",
        "XL"
    ],
    IsFeatured = false
},
new()
{
    Id = 57,
    Name = "Relaxed Summer Combo",
    Price = 2059,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Premium Cotton Blend</li>
                       <li><strong>Fit:</strong> Relaxed Fit</li>
                       <li><strong>Features:</strong> Two Piece Outfit</li>
                       <li><strong>Style:</strong> Modern Casual</li>
                  </ul>

                   <p>A coordinated casual outfit designed for comfort, travel, and everyday wear.</p>
                  """,
    Brand = "Essential",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338156",
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819796759"
    ],
    Colors =
    [
        new("Red", "#FF0000"),
        new("Black", "#000000"),
        new("White", "#FFFFFF")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL"
    ],
    IsFeatured = false
},
new()
{
    Id = 58,
    Name = "Urban Weekend Set",
    Price = 2196,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Premium Cotton Blend</li>
                       <li><strong>Fit:</strong> Relaxed Fit</li>
                       <li><strong>Features:</strong> Two Piece Outfit</li>
                       <li><strong>Style:</strong> Modern Casual</li>
                  </ul>

                   <p>A coordinated casual outfit designed for comfort, travel, and everyday wear.</p>
                  """,
    Brand = "AEL Studio",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052840379"
    ],
    Colors =
    [
        new("Blue", "#0000FF"),
        new("White", "#FFFFFF"),
        new("Black", "#000000")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL",
        "XXL"
    ],
    IsFeatured = false
},
new()
{
    Id = 59,
    Name = "Premium Streetwear Set",
    Price = 2333,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Premium Cotton Blend</li>
                       <li><strong>Fit:</strong> Relaxed Fit</li>
                       <li><strong>Features:</strong> Two Piece Outfit</li>
                       <li><strong>Style:</strong> Modern Casual</li>
                  </ul>

                   <p>A coordinated casual outfit designed for comfort, travel, and everyday wear.</p>
                  """,
    Brand = "MNML",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052838239"
    ],
    Colors =
    [
        new("Green", "#008000"),
        new("Black", "#000000"),
        new("Brown", "#A52A2A")
    ],
    Sizes =
    [
        "S",
        "M",
        "L",
        "XL",
        "XXL"
    ],
    IsFeatured = false
},
new()
{
    Id = 60,
    Name = "Essential Travel Set",
    Price = 2470,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Premium Cotton Blend</li>
                       <li><strong>Fit:</strong> Relaxed Fit</li>
                       <li><strong>Features:</strong> Two Piece Outfit</li>
                       <li><strong>Style:</strong> Modern Casual</li>
                  </ul>

                   <p>A coordinated casual outfit designed for comfort, travel, and everyday wear.</p>
                  """,
    Brand = "Puma",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/shirt-with-green-embroidery-and-plant-no-brand/1770641959695",
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231"
    ],
    Colors =
    [
        new("Beige", "#F5F5DC"),
        new("White", "#FFFFFF"),
        new("Brown", "#A52A2A")
    ],
    Sizes =
    [
        "S",
        "M",
        "L",
        "XL"
    ],
    IsFeatured = true
},
new()
{
    Id = 61,
    Name = "Modern Casual Combo",
    Price = 2607,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Premium Cotton Blend</li>
                       <li><strong>Fit:</strong> Relaxed Fit</li>
                       <li><strong>Features:</strong> Two Piece Outfit</li>
                       <li><strong>Style:</strong> Modern Casual</li>
                  </ul>

                   <p>A coordinated casual outfit designed for comfort, travel, and everyday wear.</p>
                  """,
    Brand = "Adiddydas",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819797027"
    ],
    Colors =
    [
        new("Black", "#000000"),
        new("White", "#FFFFFF"),
        new("Grey", "#808080")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL"
    ],
    IsFeatured = false
},
new()
{
    Id = 62,
    Name = "Lightweight Summer Set",
    Price = 644,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Premium Cotton Blend</li>
                       <li><strong>Fit:</strong> Relaxed Fit</li>
                       <li><strong>Features:</strong> Two Piece Outfit</li>
                       <li><strong>Style:</strong> Modern Casual</li>
                  </ul>

                   <p>A coordinated casual outfit designed for comfort, travel, and everyday wear.</p>
                  """,
    Brand = "Oxford",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819796759"
    ],
    Colors =
    [
        new("Red", "#FF0000"),
        new("Black", "#000000"),
        new("White", "#FFFFFF")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL",
        "XXL"
    ],
    IsFeatured = false
},
new()
{
    Id = 63,
    Name = "Everyday Lounge Set",
    Price = 781,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Premium Cotton Blend</li>
                       <li><strong>Fit:</strong> Relaxed Fit</li>
                       <li><strong>Features:</strong> Two Piece Outfit</li>
                       <li><strong>Style:</strong> Modern Casual</li>
                  </ul>

                   <p>A coordinated casual outfit designed for comfort, travel, and everyday wear.</p>
                  """,
    Brand = "Summer Studio",
    Status = "Out-of-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052841095",
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679"
    ],
    Colors =
    [
        new("Blue", "#0000FF"),
        new("White", "#FFFFFF"),
        new("Black", "#000000")
    ],
    Sizes =
    [
        "S",
        "M",
        "L",
        "XL",
        "XXL"
    ],
    IsFeatured = false
},
new()
{
    Id = 64,
    Name = "Minimal Street Set",
    Price = 918,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Premium Cotton Blend</li>
                       <li><strong>Fit:</strong> Relaxed Fit</li>
                       <li><strong>Features:</strong> Two Piece Outfit</li>
                       <li><strong>Style:</strong> Modern Casual</li>
                  </ul>

                   <p>A coordinated casual outfit designed for comfort, travel, and everyday wear.</p>
                  """,
    Brand = "Affirmation",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841200"
    ],
    Colors =
    [
        new("Green", "#008000"),
        new("Black", "#000000"),
        new("Brown", "#A52A2A")
    ],
    Sizes =
    [
        "S",
        "M",
        "L",
        "XL"
    ],
    IsFeatured = false
},
new()
{
    Id = 65,
    Name = "Premium Urban Combo",
    Price = 1055,
    Description = """
                  <ul>
                       <li><strong>Material:</strong> Premium Cotton Blend</li>
                       <li><strong>Fit:</strong> Relaxed Fit</li>
                       <li><strong>Features:</strong> Two Piece Outfit</li>
                       <li><strong>Style:</strong> Modern Casual</li>
                  </ul>

                   <p>A coordinated casual outfit designed for comfort, travel, and everyday wear.</p>
                  """,
    Brand = "Core Studio",
    Status = "In-Stock",
    ImageUrls =
    [
        "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231"
    ],
    Colors =
    [
        new("Beige", "#F5F5DC"),
        new("White", "#FFFFFF"),
        new("Brown", "#A52A2A")
    ],
    Sizes =
    [
        "M",
        "L",
        "XL"
    ],
    IsFeatured = true
}
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