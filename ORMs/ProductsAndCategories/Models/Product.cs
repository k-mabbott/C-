#pragma warning disable CS8618

namespace ProductsAndCategories.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


public class Product
{
    [Key]
    public int ProductId { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Description { get; set; }

    [Required (ErrorMessage ="The Price field is required.")]
    public double? Price { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public List<ProductCategory> Categories { get; set; } = new List<ProductCategory>();

}