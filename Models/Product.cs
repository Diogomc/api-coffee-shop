using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiCoffeeShop.Models;

[Table("Products")]
public class Product
{
    [Key]
    public int ProductId { get; set; }
    [Required]
    [StringLength(50)]
    public string? ProductName { get; set; }
    [Required]
    [StringLength(200)]
    public string? ProductImageUrl { get; set; }
    [Required]
    [StringLength(300)]
    public string? ProductDescription { get; set; }
    public double ProductPrice { get; set; }

    public int CategoryId { get; set; }
    public Category? Category { get; set; }
}
