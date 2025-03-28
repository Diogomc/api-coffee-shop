using Microsoft.EntityFrameworkCore;
using WebApiCoffeeShop.Models;

namespace WebApiCoffeeShop.Context;

public class ApiCoffeeShopContext : DbContext
{
    public ApiCoffeeShopContext(DbContextOptions<ApiCoffeeShopContext> options) : base(options)
    {

    }
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Product>? Products { get; set; }

}
