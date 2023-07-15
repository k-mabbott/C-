#pragma warning disable CS8618

namespace ProductsAndCategories.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


public class Category
{
    [Key]
    public int CategoryId { get; set; }

    [Required]
    public string Name { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public List<ProductCategory> Products { get; set; } = new List<ProductCategory>();

}