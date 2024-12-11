using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    [HttpGet("products")]
    public IActionResult GetProducts()
    {
        var products = new[] { "Laptop", "Smartphone", "Tablet" };
        return Ok(products);
    }
}
