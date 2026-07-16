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
    public async Task<ActionResult<List<Product>>> GetFeaturedProducts()
    {
        return Ok(await productService.GetFeaturedProducts());
    }
    [HttpGet("{id:int}")]
    public async Task<ActionResult<Product?>> GetProductById([FromRoute] int id)
    {
        return Ok(await productService.GetProductById(id));
    }
}