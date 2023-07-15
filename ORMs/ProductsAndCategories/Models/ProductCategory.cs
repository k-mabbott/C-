#pragma warning disable CS8618

namespace ProductsAndCategories.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


public class ProductCategory
{
    [Key]
    public int ProductCategoryId { get; set; }

    [Required]
    public int ProductId { get; set; }

    public Product? Product { get; set; }

    [Required]
    public int CategoryId { get; set; }
    
    public Category? Category { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;


}