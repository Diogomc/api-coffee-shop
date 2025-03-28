using Microsoft.AspNetCore.Mvc;
using WebApiCoffeeShop.Context;
using WebApiCoffeeShop.Models;

namespace WebApiCoffeeShop.Controllers;
[Route("[Controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly ApiCoffeeShopContext _context;

    public ProductController(ApiCoffeeShopContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetProducts()
    {
        var products = _context.Products.ToList();
        if (products is null)
        {
            return NotFound();
        }
        return products;
    }

    [HttpGet("{id:int}")]
    public ActionResult<Product> Get(int id)
    {
        var product = _context.Products.FirstOrDefault(p => p.ProductId == id);
        if(product is null)
        {
            return NotFound("Product not found");
        }
        return product;
    }
}
