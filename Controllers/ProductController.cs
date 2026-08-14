using esewa_market.Data.Entities;
using esewa_market.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace esewa_market.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController(
    IProductService productService
    ) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProducts(
        [FromQuery] string? category,
        [FromQuery] int page = 0,
        [FromQuery] int pageSize = 4
        )
    {
        await Task.Delay(2000);
        return Ok(await productService.GetProducts(category, page, pageSize));
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<Product?>> GetProductById(
        [FromRoute] int id
        )
    {
        return Ok(await productService.GetProductById(id));
    }

    [HttpGet("popular")]
    public ActionResult<List<string>> GetPopularProducts()
    {
        var popularCategories = new List<string>{"Baby Care", "Home and Living", "Men's Fashion",
            "Women's Fashion", "Trending Electronics", "Sports& Travels", "Daily Needs"};

        return Ok(popularCategories);
    }
}