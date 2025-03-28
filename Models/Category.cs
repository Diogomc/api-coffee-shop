using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace WebApiCoffeeShop.Models;

[Table("Categories")]
public class Category
{
    public Category()
    {
        Products = new Collection<Product>();
    }
    [Key] 
    public int CategoryId { get; set; }
    [Required]
    [StringLength(50)]
    public string? CategoryName { get; set; }
    [Required]
    [StringLength(300)]
    public string? CategoryDescription { get; set; }
    [Required]
    [StringLength(200)]
    public string? CategoryImageUrl { get; set; }

    public ICollection<Product>? Products { get; set; }

}
