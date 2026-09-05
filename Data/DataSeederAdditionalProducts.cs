using esewa_market.Data.Entities;

namespace esewa_market.Data;

public static class DataSeederAdditionalProducts
{
    public static List<Product> GetAdditionalProducts()
    {
        return new List<Product>
        {
            new()
            {
                Id = 66,
                Name = "Classic T-Shirt",
                Price = 500,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Crew Neck</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Adiddydas",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052841095"
                ],
                Colors =
                [
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF"),
                    new("Green", "#008000")
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
                Id = 67,
                Name = "Classic Shirt",
                Price = 970,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Oxford Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Puma",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841200",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231"
                ],
                Colors =
                [
                    new("Blue", "#0000FF"),
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00")
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
                Id = 68,
                Name = "Classic Polo Shirt",
                Price = 940,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Oxford",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/tshirt-blacknwhite-adiddydas/1770641109200",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/summer-setttt-ssss/1780819572953"
                ],
                Colors =
                [
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080")
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
                Id = 69,
                Name = "Classic Hoodie",
                Price = 1710,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "Essential",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/tshirt-blacknwhite-adiddydas/1770641109200"
                ],
                Colors =
                [
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500")
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
                Id = 70,
                Name = "Classic Sweatshirt",
                Price = 1480,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "MNML",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/summer-setttt-ssss/1780819572953",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679"
                ],
                Colors =
                [
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB")
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
                Id = 71,
                Name = "Classic Jacket",
                Price = 2550,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Polyester Shell with Fleece Lining</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "AEL Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/sweatshirt-puma/1770641194945",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621336359"
                ],
                Colors =
                [
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB"),
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
                Id = 72,
                Name = "Classic Shorts",
                Price = 1320,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Urban Collection",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/sweatshirt-puma/1770641194945"
                ],
                Colors =
                [
                    new("Pink", "#FFC0CB"),
                    new("Brown", "#A52A2A"),
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
                Id = 73,
                Name = "Classic Joggers",
                Price = 1590,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend Terry</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Summer Studio",
                Status = "Out-of-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621336359",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621602013"
                ],
                Colors =
                [
                    new("Brown", "#A52A2A"),
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
                Id = 74,
                Name = "Classic Jeans",
                Price = 2360,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Denim</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Core Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621602013",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621604147",
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
                    "XL"
                ],
                IsFeatured = false
            },
            new()
            {
                Id = 75,
                Name = "Classic Cap",
                Price = 330,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Twill</li>
                                  <li><strong>Fit:</strong> Adjustable</li>
                                  <li><strong>Closure:</strong> Snapback</li>
                                  <li><strong>Style:</strong> Streetwear</li>
                              </ul>

                              <p>A finishing touch for any casual outfit.</p>
                              """,
                Brand = "Affirmation",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621604147"
                ],
                Colors =
                [
                    new("White", "#FFFFFF"),
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC")
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
                Id = 76,
                Name = "Urban T-Shirt",
                Price = 1030,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Crew Neck</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Adiddydas",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/orange-sweater-celine/1770641861684",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/simple-flat-i-heart-you-valentine's-day-t-shirt-puma/1770642082740"
                ],
                Colors =
                [
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000")
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
                Id = 77,
                Name = "Urban Shirt",
                Price = 1500,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Oxford Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Puma",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/simple-flat-i-heart-you-valentine's-day-t-shirt-puma/1770642082740",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621839642",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338173"
                ],
                Colors =
                [
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF")
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
                Id = 78,
                Name = "Urban Polo Shirt",
                Price = 1470,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Oxford",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621839642"
                ],
                Colors =
                [
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF"),
                    new("Green", "#008000")
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
                Id = 79,
                Name = "Urban Hoodie",
                Price = 2240,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "Essential",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338173",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338156"
                ],
                Colors =
                [
                    new("Blue", "#0000FF"),
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00")
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
                Id = 80,
                Name = "Urban Sweatshirt",
                Price = 2010,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "MNML",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338156",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052840379",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052838239"
                ],
                Colors =
                [
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080")
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
                Id = 81,
                Name = "Urban Jacket",
                Price = 3080,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Polyester Shell with Fleece Lining</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "AEL Studio",
                Status = "Out-of-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052840379"
                ],
                Colors =
                [
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500")
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
                Id = 82,
                Name = "Urban Shorts",
                Price = 1850,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Urban Collection",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052838239",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/shirt-with-green-embroidery-and-plant-no-brand/1770641959695"
                ],
                Colors =
                [
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB")
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
                Id = 83,
                Name = "Urban Joggers",
                Price = 2120,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend Terry</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Summer Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/shirt-with-green-embroidery-and-plant-no-brand/1770641959695",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/hoodie-puma/1770640995662",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819797027"
                ],
                Colors =
                [
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB"),
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
                Id = 84,
                Name = "Urban Jeans",
                Price = 2890,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Denim</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Core Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/hoodie-puma/1770640995662"
                ],
                Colors =
                [
                    new("Pink", "#FFC0CB"),
                    new("Brown", "#A52A2A"),
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
                IsFeatured = true
            },
            new()
            {
                Id = 85,
                Name = "Urban Cap",
                Price = 860,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Twill</li>
                                  <li><strong>Fit:</strong> Adjustable</li>
                                  <li><strong>Closure:</strong> Snapback</li>
                                  <li><strong>Style:</strong> Streetwear</li>
                              </ul>

                              <p>A finishing touch for any casual outfit.</p>
                              """,
                Brand = "Affirmation",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819797027",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819796759"
                ],
                Colors =
                [
                    new("Brown", "#A52A2A"),
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
                Id = 86,
                Name = "Premium T-Shirt",
                Price = 760,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Crew Neck</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Adiddydas",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819796759",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052841095",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841200"
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
                Id = 87,
                Name = "Premium Shirt",
                Price = 2030,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Oxford Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Puma",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052841095"
                ],
                Colors =
                [
                    new("White", "#FFFFFF"),
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC")
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
                Id = 88,
                Name = "Premium Polo Shirt",
                Price = 1000,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Oxford",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841200",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231"
                ],
                Colors =
                [
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000")
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
                Id = 89,
                Name = "Premium Hoodie",
                Price = 1570,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "Essential",
                Status = "Out-of-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/tshirt-blacknwhite-adiddydas/1770641109200",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/summer-setttt-ssss/1780819572953"
                ],
                Colors =
                [
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF")
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
                Id = 90,
                Name = "Premium Sweatshirt",
                Price = 1440,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "MNML",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/tshirt-blacknwhite-adiddydas/1770641109200"
                ],
                Colors =
                [
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF"),
                    new("Green", "#008000")
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
                Id = 91,
                Name = "Premium Jacket",
                Price = 3610,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Polyester Shell with Fleece Lining</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "AEL Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/summer-setttt-ssss/1780819572953",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679"
                ],
                Colors =
                [
                    new("Blue", "#0000FF"),
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00")
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
                Id = 92,
                Name = "Premium Shorts",
                Price = 1380,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Urban Collection",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/sweatshirt-puma/1770641194945",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621336359"
                ],
                Colors =
                [
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080")
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
                Id = 93,
                Name = "Premium Joggers",
                Price = 1550,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend Terry</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Summer Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/sweatshirt-puma/1770641194945"
                ],
                Colors =
                [
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500")
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
                Id = 94,
                Name = "Premium Jeans",
                Price = 2020,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Denim</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Core Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621336359",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621602013"
                ],
                Colors =
                [
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB")
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
                Id = 95,
                Name = "Premium Cap",
                Price = 790,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Twill</li>
                                  <li><strong>Fit:</strong> Adjustable</li>
                                  <li><strong>Closure:</strong> Snapback</li>
                                  <li><strong>Style:</strong> Streetwear</li>
                              </ul>

                              <p>A finishing touch for any casual outfit.</p>
                              """,
                Brand = "Affirmation",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621602013",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621604147",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/orange-sweater-celine/1770641861684"
                ],
                Colors =
                [
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB"),
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
                Id = 96,
                Name = "Relaxed T-Shirt",
                Price = 1290,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Relaxed Fit</li>
                                  <li><strong>Neck/Collar:</strong> Crew Neck</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Adiddydas",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621604147"
                ],
                Colors =
                [
                    new("Pink", "#FFC0CB"),
                    new("Brown", "#A52A2A"),
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
                Id = 97,
                Name = "Relaxed Shirt",
                Price = 1260,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Oxford Cotton Blend</li>
                                  <li><strong>Fit:</strong> Relaxed Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Puma",
                Status = "Out-of-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/orange-sweater-celine/1770641861684",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/simple-flat-i-heart-you-valentine's-day-t-shirt-puma/1770642082740"
                ],
                Colors =
                [
                    new("Brown", "#A52A2A"),
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
                Id = 98,
                Name = "Relaxed Polo Shirt",
                Price = 1530,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Relaxed Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Oxford",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/simple-flat-i-heart-you-valentine's-day-t-shirt-puma/1770642082740",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621839642",
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
                Id = 99,
                Name = "Relaxed Hoodie",
                Price = 2100,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Relaxed Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "Essential",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621839642"
                ],
                Colors =
                [
                    new("White", "#FFFFFF"),
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC")
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
                Id = 100,
                Name = "Relaxed Sweatshirt",
                Price = 1970,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Relaxed Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "MNML",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338173",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338156"
                ],
                Colors =
                [
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000")
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
                Id = 101,
                Name = "Relaxed Jacket",
                Price = 2540,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Polyester Shell with Fleece Lining</li>
                                  <li><strong>Fit:</strong> Relaxed Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "AEL Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338156",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052840379",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052838239"
                ],
                Colors =
                [
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF")
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
                Id = 102,
                Name = "Relaxed Shorts",
                Price = 910,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend</li>
                                  <li><strong>Fit:</strong> Relaxed Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Urban Collection",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052840379"
                ],
                Colors =
                [
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF"),
                    new("Green", "#008000")
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
                Id = 103,
                Name = "Relaxed Joggers",
                Price = 2080,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend Terry</li>
                                  <li><strong>Fit:</strong> Relaxed Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Summer Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052838239",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/shirt-with-green-embroidery-and-plant-no-brand/1770641959695"
                ],
                Colors =
                [
                    new("Blue", "#0000FF"),
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00")
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
                Id = 104,
                Name = "Relaxed Jeans",
                Price = 2550,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Denim</li>
                                  <li><strong>Fit:</strong> Relaxed Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Core Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/shirt-with-green-embroidery-and-plant-no-brand/1770641959695",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/hoodie-puma/1770640995662",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819797027"
                ],
                Colors =
                [
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080")
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
                Id = 105,
                Name = "Relaxed Cap",
                Price = 720,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Twill</li>
                                  <li><strong>Fit:</strong> Adjustable</li>
                                  <li><strong>Closure:</strong> Snapback</li>
                                  <li><strong>Style:</strong> Streetwear</li>
                              </ul>

                              <p>A finishing touch for any casual outfit.</p>
                              """,
                Brand = "Affirmation",
                Status = "Out-of-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/hoodie-puma/1770640995662"
                ],
                Colors =
                [
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500")
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
                Id = 106,
                Name = "Essential T-Shirt",
                Price = 1020,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Crew Neck</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Adiddydas",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819797027",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819796759"
                ],
                Colors =
                [
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB")
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
                Id = 107,
                Name = "Essential Shirt",
                Price = 1790,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Oxford Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Puma",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819796759",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052841095",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841200"
                ],
                Colors =
                [
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB"),
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
                Id = 108,
                Name = "Essential Polo Shirt",
                Price = 1060,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Oxford",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052841095"
                ],
                Colors =
                [
                    new("Pink", "#FFC0CB"),
                    new("Brown", "#A52A2A"),
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
                Id = 109,
                Name = "Essential Hoodie",
                Price = 2630,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "Essential",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841200",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231"
                ],
                Colors =
                [
                    new("Brown", "#A52A2A"),
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
                Id = 110,
                Name = "Essential Sweatshirt",
                Price = 1400,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "MNML",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/tshirt-blacknwhite-adiddydas/1770641109200",
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
                    "S",
                    "M",
                    "L",
                    "XL"
                ],
                IsFeatured = false
            },
            new()
            {
                Id = 111,
                Name = "Essential Jacket",
                Price = 3070,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Polyester Shell with Fleece Lining</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "AEL Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/tshirt-blacknwhite-adiddydas/1770641109200"
                ],
                Colors =
                [
                    new("White", "#FFFFFF"),
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC")
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
                Id = 112,
                Name = "Essential Shorts",
                Price = 1440,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Urban Collection",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/summer-setttt-ssss/1780819572953",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679"
                ],
                Colors =
                [
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000")
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
                Id = 113,
                Name = "Essential Joggers",
                Price = 1510,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend Terry</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Summer Studio",
                Status = "Out-of-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/sweatshirt-puma/1770641194945",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621336359"
                ],
                Colors =
                [
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF")
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
                Id = 114,
                Name = "Essential Jeans",
                Price = 3080,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Denim</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Core Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/sweatshirt-puma/1770641194945"
                ],
                Colors =
                [
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF"),
                    new("Green", "#008000")
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
                Id = 115,
                Name = "Essential Cap",
                Price = 650,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Twill</li>
                                  <li><strong>Fit:</strong> Adjustable</li>
                                  <li><strong>Closure:</strong> Snapback</li>
                                  <li><strong>Style:</strong> Streetwear</li>
                              </ul>

                              <p>A finishing touch for any casual outfit.</p>
                              """,
                Brand = "Affirmation",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621336359",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621602013"
                ],
                Colors =
                [
                    new("Blue", "#0000FF"),
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00")
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
                Id = 116,
                Name = "Modern T-Shirt",
                Price = 750,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Crew Neck</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Adiddydas",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621602013",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621604147",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/orange-sweater-celine/1770641861684"
                ],
                Colors =
                [
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080")
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
                Id = 117,
                Name = "Modern Shirt",
                Price = 1020,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Oxford Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Puma",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621604147"
                ],
                Colors =
                [
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500")
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
                Id = 118,
                Name = "Modern Polo Shirt",
                Price = 1590,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Oxford",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/orange-sweater-celine/1770641861684",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/simple-flat-i-heart-you-valentine's-day-t-shirt-puma/1770642082740"
                ],
                Colors =
                [
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB")
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
                Id = 119,
                Name = "Modern Hoodie",
                Price = 1960,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "Essential",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/simple-flat-i-heart-you-valentine's-day-t-shirt-puma/1770642082740",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621839642",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338173"
                ],
                Colors =
                [
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB"),
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
                Id = 120,
                Name = "Modern Sweatshirt",
                Price = 1930,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "MNML",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621839642"
                ],
                Colors =
                [
                    new("Pink", "#FFC0CB"),
                    new("Brown", "#A52A2A"),
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
                IsFeatured = true
            },
            new()
            {
                Id = 121,
                Name = "Modern Jacket",
                Price = 3600,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Polyester Shell with Fleece Lining</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "AEL Studio",
                Status = "Out-of-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338173",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338156"
                ],
                Colors =
                [
                    new("Brown", "#A52A2A"),
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
                Id = 122,
                Name = "Modern Shorts",
                Price = 970,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Urban Collection",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338156",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052840379",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052838239"
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
                Id = 123,
                Name = "Modern Joggers",
                Price = 2040,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend Terry</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Summer Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052840379"
                ],
                Colors =
                [
                    new("White", "#FFFFFF"),
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC")
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
                Id = 124,
                Name = "Modern Jeans",
                Price = 2210,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Denim</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Core Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052838239",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/shirt-with-green-embroidery-and-plant-no-brand/1770641959695"
                ],
                Colors =
                [
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000")
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
                Id = 125,
                Name = "Modern Cap",
                Price = 580,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Twill</li>
                                  <li><strong>Fit:</strong> Adjustable</li>
                                  <li><strong>Closure:</strong> Snapback</li>
                                  <li><strong>Style:</strong> Streetwear</li>
                              </ul>

                              <p>A finishing touch for any casual outfit.</p>
                              """,
                Brand = "Affirmation",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/shirt-with-green-embroidery-and-plant-no-brand/1770641959695",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/hoodie-puma/1770640995662",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819797027"
                ],
                Colors =
                [
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF")
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
                Id = 126,
                Name = "Streetwear T-Shirt",
                Price = 1280,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Crew Neck</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Adiddydas",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/hoodie-puma/1770640995662"
                ],
                Colors =
                [
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF"),
                    new("Green", "#008000")
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
                Id = 127,
                Name = "Streetwear Shirt",
                Price = 1550,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Oxford Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Puma",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819797027",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819796759"
                ],
                Colors =
                [
                    new("Blue", "#0000FF"),
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00")
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
                Id = 128,
                Name = "Streetwear Polo Shirt",
                Price = 1120,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Oxford",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819796759",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052841095",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841200"
                ],
                Colors =
                [
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080")
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
                Id = 129,
                Name = "Streetwear Hoodie",
                Price = 2490,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "Essential",
                Status = "Out-of-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052841095"
                ],
                Colors =
                [
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500")
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
                Id = 130,
                Name = "Streetwear Sweatshirt",
                Price = 1360,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "MNML",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841200",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231"
                ],
                Colors =
                [
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB")
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
                Id = 131,
                Name = "Streetwear Jacket",
                Price = 2530,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Polyester Shell with Fleece Lining</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "AEL Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/tshirt-blacknwhite-adiddydas/1770641109200",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/summer-setttt-ssss/1780819572953"
                ],
                Colors =
                [
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB"),
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
                Id = 132,
                Name = "Streetwear Shorts",
                Price = 1500,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Urban Collection",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/tshirt-blacknwhite-adiddydas/1770641109200"
                ],
                Colors =
                [
                    new("Pink", "#FFC0CB"),
                    new("Brown", "#A52A2A"),
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
                Id = 133,
                Name = "Streetwear Joggers",
                Price = 1470,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend Terry</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Summer Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/summer-setttt-ssss/1780819572953",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679"
                ],
                Colors =
                [
                    new("Brown", "#A52A2A"),
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
                Id = 134,
                Name = "Streetwear Jeans",
                Price = 2740,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Denim</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Core Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/sweatshirt-puma/1770641194945",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621336359"
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
                Id = 135,
                Name = "Streetwear Cap",
                Price = 510,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Twill</li>
                                  <li><strong>Fit:</strong> Adjustable</li>
                                  <li><strong>Closure:</strong> Snapback</li>
                                  <li><strong>Style:</strong> Streetwear</li>
                              </ul>

                              <p>A finishing touch for any casual outfit.</p>
                              """,
                Brand = "Affirmation",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/sweatshirt-puma/1770641194945"
                ],
                Colors =
                [
                    new("White", "#FFFFFF"),
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC")
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
                Id = 136,
                Name = "Vintage T-Shirt",
                Price = 1010,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Crew Neck</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Adiddydas",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621336359",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621602013"
                ],
                Colors =
                [
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000")
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
                Id = 137,
                Name = "Vintage Shirt",
                Price = 2080,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Oxford Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Puma",
                Status = "Out-of-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621602013",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621604147",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/orange-sweater-celine/1770641861684"
                ],
                Colors =
                [
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF")
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
                Id = 138,
                Name = "Vintage Polo Shirt",
                Price = 1650,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Oxford",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621604147"
                ],
                Colors =
                [
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF"),
                    new("Green", "#008000")
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
                Id = 139,
                Name = "Vintage Hoodie",
                Price = 1820,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "Essential",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/orange-sweater-celine/1770641861684",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/simple-flat-i-heart-you-valentine's-day-t-shirt-puma/1770642082740"
                ],
                Colors =
                [
                    new("Blue", "#0000FF"),
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00")
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
                Id = 140,
                Name = "Vintage Sweatshirt",
                Price = 1890,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "MNML",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/simple-flat-i-heart-you-valentine's-day-t-shirt-puma/1770642082740",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621839642",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338173"
                ],
                Colors =
                [
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080")
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
                Id = 141,
                Name = "Vintage Jacket",
                Price = 3060,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Polyester Shell with Fleece Lining</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "AEL Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621839642"
                ],
                Colors =
                [
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500")
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
                Id = 142,
                Name = "Vintage Shorts",
                Price = 1030,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Urban Collection",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338173",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338156"
                ],
                Colors =
                [
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB")
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
                Id = 143,
                Name = "Vintage Joggers",
                Price = 2000,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend Terry</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Summer Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338156",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052840379",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052838239"
                ],
                Colors =
                [
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB"),
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
                Id = 144,
                Name = "Vintage Jeans",
                Price = 1870,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Denim</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Core Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052840379"
                ],
                Colors =
                [
                    new("Pink", "#FFC0CB"),
                    new("Brown", "#A52A2A"),
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
                Id = 145,
                Name = "Vintage Cap",
                Price = 440,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Twill</li>
                                  <li><strong>Fit:</strong> Adjustable</li>
                                  <li><strong>Closure:</strong> Snapback</li>
                                  <li><strong>Style:</strong> Streetwear</li>
                              </ul>

                              <p>A finishing touch for any casual outfit.</p>
                              """,
                Brand = "Affirmation",
                Status = "Out-of-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052838239",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/shirt-with-green-embroidery-and-plant-no-brand/1770641959695"
                ],
                Colors =
                [
                    new("Brown", "#A52A2A"),
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
                Id = 146,
                Name = "Minimal T-Shirt",
                Price = 740,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Crew Neck</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Adiddydas",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/shirt-with-green-embroidery-and-plant-no-brand/1770641959695",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/hoodie-puma/1770640995662",
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
                    "S",
                    "M",
                    "L",
                    "XL"
                ],
                IsFeatured = false
            },
            new()
            {
                Id = 147,
                Name = "Minimal Shirt",
                Price = 1310,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Oxford Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Puma",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/hoodie-puma/1770640995662"
                ],
                Colors =
                [
                    new("White", "#FFFFFF"),
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC")
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
                Id = 148,
                Name = "Minimal Polo Shirt",
                Price = 1180,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Oxford",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819797027",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819796759"
                ],
                Colors =
                [
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000")
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
                Id = 149,
                Name = "Minimal Hoodie",
                Price = 2350,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "Essential",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819796759",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052841095",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841200"
                ],
                Colors =
                [
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF")
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
                Id = 150,
                Name = "Minimal Sweatshirt",
                Price = 1320,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "MNML",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052841095"
                ],
                Colors =
                [
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF"),
                    new("Green", "#008000")
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
                Id = 151,
                Name = "Minimal Jacket",
                Price = 3590,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Polyester Shell with Fleece Lining</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "AEL Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841200",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231"
                ],
                Colors =
                [
                    new("Blue", "#0000FF"),
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00")
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
                Id = 152,
                Name = "Minimal Shorts",
                Price = 1560,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Urban Collection",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/tshirt-blacknwhite-adiddydas/1770641109200",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/summer-setttt-ssss/1780819572953"
                ],
                Colors =
                [
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080")
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
                Id = 153,
                Name = "Minimal Joggers",
                Price = 1430,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend Terry</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Summer Studio",
                Status = "Out-of-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/tshirt-blacknwhite-adiddydas/1770641109200"
                ],
                Colors =
                [
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500")
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
                Id = 154,
                Name = "Minimal Jeans",
                Price = 2400,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Denim</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Core Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/summer-setttt-ssss/1780819572953",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679"
                ],
                Colors =
                [
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB")
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
                Id = 155,
                Name = "Minimal Cap",
                Price = 370,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Twill</li>
                                  <li><strong>Fit:</strong> Adjustable</li>
                                  <li><strong>Closure:</strong> Snapback</li>
                                  <li><strong>Style:</strong> Streetwear</li>
                              </ul>

                              <p>A finishing touch for any casual outfit.</p>
                              """,
                Brand = "Affirmation",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/sweatshirt-puma/1770641194945",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621336359"
                ],
                Colors =
                [
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB"),
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
                Id = 156,
                Name = "Everyday T-Shirt",
                Price = 1270,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Crew Neck</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Adiddydas",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/sweatshirt-puma/1770641194945"
                ],
                Colors =
                [
                    new("Pink", "#FFC0CB"),
                    new("Brown", "#A52A2A"),
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
                IsFeatured = true
            },
            new()
            {
                Id = 157,
                Name = "Everyday Shirt",
                Price = 1840,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Oxford Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Puma",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621336359",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621602013"
                ],
                Colors =
                [
                    new("Brown", "#A52A2A"),
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
                Id = 158,
                Name = "Everyday Polo Shirt",
                Price = 1710,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Oxford",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621602013",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621604147",
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
                    "XL"
                ],
                IsFeatured = false
            },
            new()
            {
                Id = 159,
                Name = "Everyday Hoodie",
                Price = 1680,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "Essential",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621604147"
                ],
                Colors =
                [
                    new("White", "#FFFFFF"),
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC")
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
                Id = 160,
                Name = "Everyday Sweatshirt",
                Price = 1850,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "MNML",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/orange-sweater-celine/1770641861684",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/simple-flat-i-heart-you-valentine's-day-t-shirt-puma/1770642082740"
                ],
                Colors =
                [
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000")
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
                Id = 161,
                Name = "Everyday Jacket",
                Price = 2520,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Polyester Shell with Fleece Lining</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "AEL Studio",
                Status = "Out-of-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/simple-flat-i-heart-you-valentine's-day-t-shirt-puma/1770642082740",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621839642",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338173"
                ],
                Colors =
                [
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF")
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
                Id = 162,
                Name = "Everyday Shorts",
                Price = 1090,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Urban Collection",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621839642"
                ],
                Colors =
                [
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF"),
                    new("Green", "#008000")
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
                Id = 163,
                Name = "Everyday Joggers",
                Price = 1960,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend Terry</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Summer Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338173",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338156"
                ],
                Colors =
                [
                    new("Blue", "#0000FF"),
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00")
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
                Id = 164,
                Name = "Everyday Jeans",
                Price = 2930,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Denim</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Core Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338156",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052840379",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052838239"
                ],
                Colors =
                [
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080")
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
                Id = 165,
                Name = "Everyday Cap",
                Price = 300,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Twill</li>
                                  <li><strong>Fit:</strong> Adjustable</li>
                                  <li><strong>Closure:</strong> Snapback</li>
                                  <li><strong>Style:</strong> Streetwear</li>
                              </ul>

                              <p>A finishing touch for any casual outfit.</p>
                              """,
                Brand = "Affirmation",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052840379"
                ],
                Colors =
                [
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500")
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
                Id = 166,
                Name = "Casual T-Shirt",
                Price = 1000,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Crew Neck</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Adiddydas",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052838239",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/shirt-with-green-embroidery-and-plant-no-brand/1770641959695"
                ],
                Colors =
                [
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB")
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
                Id = 167,
                Name = "Casual Shirt",
                Price = 1070,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Oxford Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Puma",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/shirt-with-green-embroidery-and-plant-no-brand/1770641959695",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/hoodie-puma/1770640995662",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819797027"
                ],
                Colors =
                [
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB"),
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
                Id = 168,
                Name = "Casual Polo Shirt",
                Price = 1240,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Oxford",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/hoodie-puma/1770640995662"
                ],
                Colors =
                [
                    new("Pink", "#FFC0CB"),
                    new("Brown", "#A52A2A"),
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
                Id = 169,
                Name = "Casual Hoodie",
                Price = 2210,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "Essential",
                Status = "Out-of-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819797027",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819796759"
                ],
                Colors =
                [
                    new("Brown", "#A52A2A"),
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
                Id = 170,
                Name = "Casual Sweatshirt",
                Price = 1280,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "MNML",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819796759",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052841095",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841200"
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
                Id = 171,
                Name = "Casual Jacket",
                Price = 3050,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Polyester Shell with Fleece Lining</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "AEL Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052841095"
                ],
                Colors =
                [
                    new("White", "#FFFFFF"),
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC")
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
                Id = 172,
                Name = "Casual Shorts",
                Price = 1620,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Urban Collection",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841200",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231"
                ],
                Colors =
                [
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000")
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
                Id = 173,
                Name = "Casual Joggers",
                Price = 1390,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend Terry</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Summer Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/tshirt-blacknwhite-adiddydas/1770641109200",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/summer-setttt-ssss/1780819572953"
                ],
                Colors =
                [
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF")
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
                Id = 174,
                Name = "Casual Jeans",
                Price = 2060,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Denim</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Core Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/tshirt-blacknwhite-adiddydas/1770641109200"
                ],
                Colors =
                [
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF"),
                    new("Green", "#008000")
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
                Id = 175,
                Name = "Casual Cap",
                Price = 830,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Twill</li>
                                  <li><strong>Fit:</strong> Adjustable</li>
                                  <li><strong>Closure:</strong> Snapback</li>
                                  <li><strong>Style:</strong> Streetwear</li>
                              </ul>

                              <p>A finishing touch for any casual outfit.</p>
                              """,
                Brand = "Affirmation",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/summer-setttt-ssss/1780819572953",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679"
                ],
                Colors =
                [
                    new("Blue", "#0000FF"),
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00")
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
                Id = 176,
                Name = "Athletic T-Shirt",
                Price = 730,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Crew Neck</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Adiddydas",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/sweatshirt-puma/1770641194945",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621336359"
                ],
                Colors =
                [
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080")
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
                Id = 177,
                Name = "Athletic Shirt",
                Price = 1600,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Oxford Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Puma",
                Status = "Out-of-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/sweatshirt-puma/1770641194945"
                ],
                Colors =
                [
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500")
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
                Id = 178,
                Name = "Athletic Polo Shirt",
                Price = 1770,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Oxford",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621336359",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621602013"
                ],
                Colors =
                [
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB")
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
                Id = 179,
                Name = "Athletic Hoodie",
                Price = 1540,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "Essential",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621602013",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621604147",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/orange-sweater-celine/1770641861684"
                ],
                Colors =
                [
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB"),
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
                Id = 180,
                Name = "Athletic Sweatshirt",
                Price = 1810,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "MNML",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621604147"
                ],
                Colors =
                [
                    new("Pink", "#FFC0CB"),
                    new("Brown", "#A52A2A"),
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
                Id = 181,
                Name = "Athletic Jacket",
                Price = 3580,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Polyester Shell with Fleece Lining</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "AEL Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/orange-sweater-celine/1770641861684",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/simple-flat-i-heart-you-valentine's-day-t-shirt-puma/1770642082740"
                ],
                Colors =
                [
                    new("Brown", "#A52A2A"),
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
                Id = 182,
                Name = "Athletic Shorts",
                Price = 1150,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Urban Collection",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/simple-flat-i-heart-you-valentine's-day-t-shirt-puma/1770642082740",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621839642",
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
                Id = 183,
                Name = "Athletic Joggers",
                Price = 1920,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend Terry</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Summer Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621839642"
                ],
                Colors =
                [
                    new("White", "#FFFFFF"),
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC")
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
                Id = 184,
                Name = "Athletic Jeans",
                Price = 2590,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Denim</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Core Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338173",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338156"
                ],
                Colors =
                [
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000")
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
                Id = 185,
                Name = "Athletic Cap",
                Price = 760,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Twill</li>
                                  <li><strong>Fit:</strong> Adjustable</li>
                                  <li><strong>Closure:</strong> Snapback</li>
                                  <li><strong>Style:</strong> Streetwear</li>
                              </ul>

                              <p>A finishing touch for any casual outfit.</p>
                              """,
                Brand = "Affirmation",
                Status = "Out-of-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338156",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052840379",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052838239"
                ],
                Colors =
                [
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF")
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
                Id = 186,
                Name = "Slim-Fit T-Shirt",
                Price = 1260,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Slim Fit</li>
                                  <li><strong>Neck/Collar:</strong> Crew Neck</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Adiddydas",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052840379"
                ],
                Colors =
                [
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF"),
                    new("Green", "#008000")
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
                Id = 187,
                Name = "Slim-Fit Shirt",
                Price = 2130,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Oxford Cotton Blend</li>
                                  <li><strong>Fit:</strong> Slim Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Puma",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052838239",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/shirt-with-green-embroidery-and-plant-no-brand/1770641959695"
                ],
                Colors =
                [
                    new("Blue", "#0000FF"),
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00")
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
                Id = 188,
                Name = "Slim-Fit Polo Shirt",
                Price = 1300,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Slim Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Oxford",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/shirt-with-green-embroidery-and-plant-no-brand/1770641959695",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/hoodie-puma/1770640995662",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819797027"
                ],
                Colors =
                [
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080")
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
                Id = 189,
                Name = "Slim-Fit Hoodie",
                Price = 2070,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Slim Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "Essential",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/hoodie-puma/1770640995662"
                ],
                Colors =
                [
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500")
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
                Id = 190,
                Name = "Slim-Fit Sweatshirt",
                Price = 1240,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Slim Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "MNML",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819797027",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819796759"
                ],
                Colors =
                [
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB")
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
                Id = 191,
                Name = "Slim-Fit Jacket",
                Price = 2510,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Polyester Shell with Fleece Lining</li>
                                  <li><strong>Fit:</strong> Slim Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "AEL Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819796759",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052841095",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841200"
                ],
                Colors =
                [
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB"),
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
                Id = 192,
                Name = "Slim-Fit Shorts",
                Price = 1680,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend</li>
                                  <li><strong>Fit:</strong> Slim Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Urban Collection",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052841095"
                ],
                Colors =
                [
                    new("Pink", "#FFC0CB"),
                    new("Brown", "#A52A2A"),
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
                IsFeatured = true
            },
            new()
            {
                Id = 193,
                Name = "Slim-Fit Joggers",
                Price = 1350,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend Terry</li>
                                  <li><strong>Fit:</strong> Slim Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Summer Studio",
                Status = "Out-of-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841200",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231"
                ],
                Colors =
                [
                    new("Brown", "#A52A2A"),
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
                Id = 194,
                Name = "Slim-Fit Jeans",
                Price = 3120,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Denim</li>
                                  <li><strong>Fit:</strong> Slim Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Core Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/tshirt-blacknwhite-adiddydas/1770641109200",
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
                    "S",
                    "M",
                    "L",
                    "XL"
                ],
                IsFeatured = false
            },
            new()
            {
                Id = 195,
                Name = "Slim-Fit Cap",
                Price = 690,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Twill</li>
                                  <li><strong>Fit:</strong> Adjustable</li>
                                  <li><strong>Closure:</strong> Snapback</li>
                                  <li><strong>Style:</strong> Streetwear</li>
                              </ul>

                              <p>A finishing touch for any casual outfit.</p>
                              """,
                Brand = "Affirmation",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/tshirt-blacknwhite-adiddydas/1770641109200"
                ],
                Colors =
                [
                    new("White", "#FFFFFF"),
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC")
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
                Id = 196,
                Name = "Oversized T-Shirt",
                Price = 990,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Oversized</li>
                                  <li><strong>Neck/Collar:</strong> Crew Neck</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Adiddydas",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/summer-setttt-ssss/1780819572953",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679"
                ],
                Colors =
                [
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000")
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
                Id = 197,
                Name = "Oversized Shirt",
                Price = 1360,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Oxford Cotton Blend</li>
                                  <li><strong>Fit:</strong> Oversized</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Puma",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/sweatshirt-puma/1770641194945",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621336359"
                ],
                Colors =
                [
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF")
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
                Id = 198,
                Name = "Oversized Polo Shirt",
                Price = 830,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Oversized</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Oxford",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/sweatshirt-puma/1770641194945"
                ],
                Colors =
                [
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF"),
                    new("Green", "#008000")
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
                Id = 199,
                Name = "Oversized Hoodie",
                Price = 2600,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Oversized</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "Essential",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621336359",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621602013"
                ],
                Colors =
                [
                    new("Blue", "#0000FF"),
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00")
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
                Id = 200,
                Name = "Oversized Sweatshirt",
                Price = 1770,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Oversized</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "MNML",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621602013",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621604147",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/orange-sweater-celine/1770641861684"
                ],
                Colors =
                [
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080")
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
                Id = 201,
                Name = "Oversized Jacket",
                Price = 3040,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Polyester Shell with Fleece Lining</li>
                                  <li><strong>Fit:</strong> Oversized</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "AEL Studio",
                Status = "Out-of-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621604147"
                ],
                Colors =
                [
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500")
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
                Id = 202,
                Name = "Oversized Shorts",
                Price = 1210,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend</li>
                                  <li><strong>Fit:</strong> Oversized</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Urban Collection",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/orange-sweater-celine/1770641861684",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/simple-flat-i-heart-you-valentine's-day-t-shirt-puma/1770642082740"
                ],
                Colors =
                [
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB")
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
                Id = 203,
                Name = "Oversized Joggers",
                Price = 1880,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend Terry</li>
                                  <li><strong>Fit:</strong> Oversized</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Summer Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/simple-flat-i-heart-you-valentine's-day-t-shirt-puma/1770642082740",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621839642",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338173"
                ],
                Colors =
                [
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB"),
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
                Id = 204,
                Name = "Oversized Jeans",
                Price = 2250,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Denim</li>
                                  <li><strong>Fit:</strong> Oversized</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Core Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621839642"
                ],
                Colors =
                [
                    new("Pink", "#FFC0CB"),
                    new("Brown", "#A52A2A"),
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
                Id = 205,
                Name = "Oversized Cap",
                Price = 620,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Twill</li>
                                  <li><strong>Fit:</strong> Adjustable</li>
                                  <li><strong>Closure:</strong> Snapback</li>
                                  <li><strong>Style:</strong> Streetwear</li>
                              </ul>

                              <p>A finishing touch for any casual outfit.</p>
                              """,
                Brand = "Affirmation",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338173",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338156"
                ],
                Colors =
                [
                    new("Brown", "#A52A2A"),
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
                Id = 206,
                Name = "Comfort T-Shirt",
                Price = 720,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Crew Neck</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Adiddydas",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338156",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052840379",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052838239"
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
                Id = 207,
                Name = "Comfort Shirt",
                Price = 1890,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Oxford Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Puma",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052840379"
                ],
                Colors =
                [
                    new("White", "#FFFFFF"),
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC")
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
                Id = 208,
                Name = "Comfort Polo Shirt",
                Price = 1360,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Oxford",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052838239",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/shirt-with-green-embroidery-and-plant-no-brand/1770641959695"
                ],
                Colors =
                [
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000")
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
                Id = 209,
                Name = "Comfort Hoodie",
                Price = 1930,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "Essential",
                Status = "Out-of-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/shirt-with-green-embroidery-and-plant-no-brand/1770641959695",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/hoodie-puma/1770640995662",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819797027"
                ],
                Colors =
                [
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF")
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
                Id = 210,
                Name = "Comfort Sweatshirt",
                Price = 1200,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "MNML",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/hoodie-puma/1770640995662"
                ],
                Colors =
                [
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF"),
                    new("Green", "#008000")
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
                Id = 211,
                Name = "Comfort Jacket",
                Price = 3570,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Polyester Shell with Fleece Lining</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "AEL Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819797027",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819796759"
                ],
                Colors =
                [
                    new("Blue", "#0000FF"),
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00")
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
                Id = 212,
                Name = "Comfort Shorts",
                Price = 1740,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Urban Collection",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819796759",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052841095",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841200"
                ],
                Colors =
                [
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080")
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
                Id = 213,
                Name = "Comfort Joggers",
                Price = 1310,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend Terry</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Summer Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052841095"
                ],
                Colors =
                [
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500")
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
                Id = 214,
                Name = "Comfort Jeans",
                Price = 2780,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Denim</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Core Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841200",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231"
                ],
                Colors =
                [
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB")
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
                Id = 215,
                Name = "Comfort Cap",
                Price = 550,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Twill</li>
                                  <li><strong>Fit:</strong> Adjustable</li>
                                  <li><strong>Closure:</strong> Snapback</li>
                                  <li><strong>Style:</strong> Streetwear</li>
                              </ul>

                              <p>A finishing touch for any casual outfit.</p>
                              """,
                Brand = "Affirmation",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/tshirt-blacknwhite-adiddydas/1770641109200",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/summer-setttt-ssss/1780819572953"
                ],
                Colors =
                [
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB"),
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
                Id = 216,
                Name = "Heritage T-Shirt",
                Price = 1250,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Crew Neck</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Adiddydas",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/tshirt-blacknwhite-adiddydas/1770641109200"
                ],
                Colors =
                [
                    new("Pink", "#FFC0CB"),
                    new("Brown", "#A52A2A"),
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
                Id = 217,
                Name = "Heritage Shirt",
                Price = 1120,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Oxford Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Puma",
                Status = "Out-of-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/summer-setttt-ssss/1780819572953",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679"
                ],
                Colors =
                [
                    new("Brown", "#A52A2A"),
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
                Id = 218,
                Name = "Heritage Polo Shirt",
                Price = 890,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Oxford",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/sweatshirt-puma/1770641194945",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621336359"
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
                Id = 219,
                Name = "Heritage Hoodie",
                Price = 2460,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "Essential",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/sweatshirt-puma/1770641194945"
                ],
                Colors =
                [
                    new("White", "#FFFFFF"),
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC")
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
                Id = 220,
                Name = "Heritage Sweatshirt",
                Price = 1730,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "MNML",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621336359",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621602013"
                ],
                Colors =
                [
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000")
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
                Id = 221,
                Name = "Heritage Jacket",
                Price = 2500,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Polyester Shell with Fleece Lining</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "AEL Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621602013",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621604147",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/orange-sweater-celine/1770641861684"
                ],
                Colors =
                [
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF")
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
                Id = 222,
                Name = "Heritage Shorts",
                Price = 1270,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Urban Collection",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621604147"
                ],
                Colors =
                [
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF"),
                    new("Green", "#008000")
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
                Id = 223,
                Name = "Heritage Joggers",
                Price = 1840,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend Terry</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Summer Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/orange-sweater-celine/1770641861684",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/simple-flat-i-heart-you-valentine's-day-t-shirt-puma/1770642082740"
                ],
                Colors =
                [
                    new("Blue", "#0000FF"),
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00")
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
                Id = 224,
                Name = "Heritage Jeans",
                Price = 1910,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Denim</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Core Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/simple-flat-i-heart-you-valentine's-day-t-shirt-puma/1770642082740",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621839642",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338173"
                ],
                Colors =
                [
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080")
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
                Id = 225,
                Name = "Heritage Cap",
                Price = 480,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Twill</li>
                                  <li><strong>Fit:</strong> Adjustable</li>
                                  <li><strong>Closure:</strong> Snapback</li>
                                  <li><strong>Style:</strong> Streetwear</li>
                              </ul>

                              <p>A finishing touch for any casual outfit.</p>
                              """,
                Brand = "Affirmation",
                Status = "Out-of-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621839642"
                ],
                Colors =
                [
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500")
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
                Id = 226,
                Name = "Bold T-Shirt",
                Price = 980,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Crew Neck</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Adiddydas",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338173",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338156"
                ],
                Colors =
                [
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB")
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
                Id = 227,
                Name = "Bold Shirt",
                Price = 1650,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Oxford Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Puma",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338156",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052840379",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052838239"
                ],
                Colors =
                [
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB"),
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
                Id = 228,
                Name = "Bold Polo Shirt",
                Price = 1420,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Oxford",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052840379"
                ],
                Colors =
                [
                    new("Pink", "#FFC0CB"),
                    new("Brown", "#A52A2A"),
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
                IsFeatured = true
            },
            new()
            {
                Id = 229,
                Name = "Bold Hoodie",
                Price = 1790,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "Essential",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052838239",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/shirt-with-green-embroidery-and-plant-no-brand/1770641959695"
                ],
                Colors =
                [
                    new("Brown", "#A52A2A"),
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
                Id = 230,
                Name = "Bold Sweatshirt",
                Price = 2260,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "MNML",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/shirt-with-green-embroidery-and-plant-no-brand/1770641959695",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/hoodie-puma/1770640995662",
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
                    "S",
                    "M",
                    "L",
                    "XL"
                ],
                IsFeatured = false
            },
            new()
            {
                Id = 231,
                Name = "Bold Jacket",
                Price = 3030,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Polyester Shell with Fleece Lining</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "AEL Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/hoodie-puma/1770640995662"
                ],
                Colors =
                [
                    new("White", "#FFFFFF"),
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC")
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
                Id = 232,
                Name = "Bold Shorts",
                Price = 1800,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
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
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000")
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
                Id = 233,
                Name = "Bold Joggers",
                Price = 1270,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend Terry</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Summer Studio",
                Status = "Out-of-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819796759",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052841095",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841200"
                ],
                Colors =
                [
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF")
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
                Id = 234,
                Name = "Bold Jeans",
                Price = 2440,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Denim</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Core Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052841095"
                ],
                Colors =
                [
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF"),
                    new("Green", "#008000")
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
                Id = 235,
                Name = "Bold Cap",
                Price = 410,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Twill</li>
                                  <li><strong>Fit:</strong> Adjustable</li>
                                  <li><strong>Closure:</strong> Snapback</li>
                                  <li><strong>Style:</strong> Streetwear</li>
                              </ul>

                              <p>A finishing touch for any casual outfit.</p>
                              """,
                Brand = "Affirmation",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841200",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231"
                ],
                Colors =
                [
                    new("Blue", "#0000FF"),
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00")
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
                Id = 236,
                Name = "Signature T-Shirt",
                Price = 710,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Crew Neck</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Adiddydas",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/tshirt-blacknwhite-adiddydas/1770641109200",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/summer-setttt-ssss/1780819572953"
                ],
                Colors =
                [
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080")
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
                Id = 237,
                Name = "Signature Shirt",
                Price = 2180,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Oxford Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Puma",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/tshirt-blacknwhite-adiddydas/1770641109200"
                ],
                Colors =
                [
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500")
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
                Id = 238,
                Name = "Signature Polo Shirt",
                Price = 950,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Oxford",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/summer-setttt-ssss/1780819572953",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679"
                ],
                Colors =
                [
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB")
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
                Id = 239,
                Name = "Signature Hoodie",
                Price = 2320,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "Essential",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/sweatshirt-puma/1770641194945",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621336359"
                ],
                Colors =
                [
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB"),
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
                Id = 240,
                Name = "Signature Sweatshirt",
                Price = 1690,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "MNML",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/sweatshirt-puma/1770641194945"
                ],
                Colors =
                [
                    new("Pink", "#FFC0CB"),
                    new("Brown", "#A52A2A"),
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
                Id = 241,
                Name = "Signature Jacket",
                Price = 3560,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Polyester Shell with Fleece Lining</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "AEL Studio",
                Status = "Out-of-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621336359",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621602013"
                ],
                Colors =
                [
                    new("Brown", "#A52A2A"),
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
                Id = 242,
                Name = "Signature Shorts",
                Price = 1330,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Urban Collection",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621602013",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621604147",
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
                    "XL"
                ],
                IsFeatured = false
            },
            new()
            {
                Id = 243,
                Name = "Signature Joggers",
                Price = 1800,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend Terry</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Summer Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621604147"
                ],
                Colors =
                [
                    new("White", "#FFFFFF"),
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC")
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
                Id = 244,
                Name = "Signature Jeans",
                Price = 2970,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Denim</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Core Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/orange-sweater-celine/1770641861684",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/simple-flat-i-heart-you-valentine's-day-t-shirt-puma/1770642082740"
                ],
                Colors =
                [
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000")
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
                Id = 245,
                Name = "Signature Cap",
                Price = 340,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Twill</li>
                                  <li><strong>Fit:</strong> Adjustable</li>
                                  <li><strong>Closure:</strong> Snapback</li>
                                  <li><strong>Style:</strong> Streetwear</li>
                              </ul>

                              <p>A finishing touch for any casual outfit.</p>
                              """,
                Brand = "Affirmation",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/simple-flat-i-heart-you-valentine's-day-t-shirt-puma/1770642082740",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621839642",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338173"
                ],
                Colors =
                [
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF")
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
                Id = 246,
                Name = "Active T-Shirt",
                Price = 1240,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Crew Neck</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Adiddydas",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621839642"
                ],
                Colors =
                [
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF"),
                    new("Green", "#008000")
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
                Id = 247,
                Name = "Active Shirt",
                Price = 1410,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Oxford Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Puma",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338173",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338156"
                ],
                Colors =
                [
                    new("Blue", "#0000FF"),
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00")
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
                Id = 248,
                Name = "Active Polo Shirt",
                Price = 1480,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Oxford",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621338156",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052840379",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052838239"
                ],
                Colors =
                [
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080")
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
                Id = 249,
                Name = "Active Hoodie",
                Price = 1650,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "Essential",
                Status = "Out-of-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052840379"
                ],
                Colors =
                [
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500")
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
                Id = 250,
                Name = "Active Sweatshirt",
                Price = 2220,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "MNML",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052838239",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/shirt-with-green-embroidery-and-plant-no-brand/1770641959695"
                ],
                Colors =
                [
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB")
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
                Id = 251,
                Name = "Active Jacket",
                Price = 2490,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Polyester Shell with Fleece Lining</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "AEL Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/shirt-with-green-embroidery-and-plant-no-brand/1770641959695",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/hoodie-puma/1770640995662",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819797027"
                ],
                Colors =
                [
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB"),
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
                Id = 252,
                Name = "Active Shorts",
                Price = 1860,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Urban Collection",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/hoodie-puma/1770640995662"
                ],
                Colors =
                [
                    new("Pink", "#FFC0CB"),
                    new("Brown", "#A52A2A"),
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
                Id = 253,
                Name = "Active Joggers",
                Price = 1230,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend Terry</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Summer Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819797027",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819796759"
                ],
                Colors =
                [
                    new("Brown", "#A52A2A"),
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
                Id = 254,
                Name = "Active Jeans",
                Price = 2100,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Denim</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Core Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/pranish-nicks/1780819796759",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052841095",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841200"
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
                Id = 255,
                Name = "Active Cap",
                Price = 870,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Twill</li>
                                  <li><strong>Fit:</strong> Adjustable</li>
                                  <li><strong>Closure:</strong> Snapback</li>
                                  <li><strong>Style:</strong> Streetwear</li>
                              </ul>

                              <p>A finishing touch for any casual outfit.</p>
                              """,
                Brand = "Affirmation",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/white-oxford-shirt-oxford/1773052841095"
                ],
                Colors =
                [
                    new("White", "#FFFFFF"),
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC")
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
                Id = 256,
                Name = "Elite T-Shirt",
                Price = 970,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Crew Neck</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Adiddydas",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841200",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231"
                ],
                Colors =
                [
                    new("Grey", "#808080"),
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000")
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
                Id = 257,
                Name = "Elite Shirt",
                Price = 1940,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Oxford Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Puma",
                Status = "Out-of-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/mnml-men's-front-pocket-geo-shorts-mnml-/1770621841231",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/tshirt-blacknwhite-adiddydas/1770641109200",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/summer-setttt-ssss/1780819572953"
                ],
                Colors =
                [
                    new("Beige", "#F5F5DC"),
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF")
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
                Id = 258,
                Name = "Elite Polo Shirt",
                Price = 1010,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> 100% Cotton</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Neck/Collar:</strong> Button Down Collar</li>
                                  <li><strong>Care:</strong> Machine Wash</li>
                              </ul>

                              <p>Perfect for daily wear, travel, and casual outings.</p>
                              """,
                Brand = "Oxford",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/tshirt-blacknwhite-adiddydas/1770641109200"
                ],
                Colors =
                [
                    new("Red", "#FF0000"),
                    new("Blue", "#0000FF"),
                    new("Green", "#008000")
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
                Id = 259,
                Name = "Elite Hoodie",
                Price = 2180,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "Essential",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/summer-setttt-ssss/1780819572953",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679"
                ],
                Colors =
                [
                    new("Blue", "#0000FF"),
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00")
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
                Id = 260,
                Name = "Elite Sweatshirt",
                Price = 1650,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Fleece</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "MNML",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/red-hoodie-adiddydas/1770641449679",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/sweatshirt-puma/1770641194945",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621336359"
                ],
                Colors =
                [
                    new("Green", "#008000"),
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080")
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
                Id = 261,
                Name = "Elite Jacket",
                Price = 3020,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Polyester Shell with Fleece Lining</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Features:</strong> Adjustable Hood / Ribbed Cuffs</li>
                                  <li><strong>Pocket:</strong> Front Kangaroo Pocket</li>
                              </ul>

                              <p>Great for layering and cooler weather.</p>
                              """,
                Brand = "AEL Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/sweatshirt-puma/1770641194945"
                ],
                Colors =
                [
                    new("Yellow", "#FFFF00"),
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500")
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
                Id = 262,
                Name = "Elite Shorts",
                Price = 1390,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Urban Collection",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/affirmation-hoodie-affirmation-/1770621336359",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621602013"
                ],
                Colors =
                [
                    new("Purple", "#800080"),
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB")
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
                Id = 263,
                Name = "Elite Joggers",
                Price = 1760,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Blend Terry</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Summer Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621602013",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621604147",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/orange-sweater-celine/1770641861684"
                ],
                Colors =
                [
                    new("Orange", "#FFA500"),
                    new("Pink", "#FFC0CB"),
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
                Id = 264,
                Name = "Elite Jeans",
                Price = 2630,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Denim</li>
                                  <li><strong>Fit:</strong> Regular Fit</li>
                                  <li><strong>Pockets:</strong> Front Utility Pockets</li>
                                  <li><strong>Style:</strong> Casual</li>
                              </ul>

                              <p>Comfortable for everyday wear and warm weather.</p>
                              """,
                Brand = "Core Studio",
                Status = "In-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/translucent-shirt-ael-studio/1770621604147"
                ],
                Colors =
                [
                    new("Pink", "#FFC0CB"),
                    new("Brown", "#A52A2A"),
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
                IsFeatured = true
            },
            new()
            {
                Id = 265,
                Name = "Elite Cap",
                Price = 800,
                Description = """
                              <ul>
                                  <li><strong>Material:</strong> Cotton Twill</li>
                                  <li><strong>Fit:</strong> Adjustable</li>
                                  <li><strong>Closure:</strong> Snapback</li>
                                  <li><strong>Style:</strong> Streetwear</li>
                              </ul>

                              <p>A finishing touch for any casual outfit.</p>
                              """,
                Brand = "Affirmation",
                Status = "Out-of-Stock",
                ImageUrls =
                [
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/orange-sweater-celine/1770641861684",
                    "https://gqtuuqsgkyffgcpbfltk.supabase.co/storage/v1/object/public/product-images/simple-flat-i-heart-you-valentine's-day-t-shirt-puma/1770642082740"
                ],
                Colors =
                [
                    new("Brown", "#A52A2A"),
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
            }
        };
    }
}