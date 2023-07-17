#pragma warning disable CS8618

namespace ChefsAndDishes.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


public class Dish
{
    [Key]
    public int DishId { get; set; }


    [Display(Name = "Name of the Dish")]
    [Required]
    [MaxLength(45, ErrorMessage ="Name must be less than 45 characters long")]
    public string Name { get; set; }


    [Required (ErrorMessage="The Tastiness field is required")]
    [Range(1,5, ErrorMessage ="The Tastiness field is required")]
    public int? Tastiness { get; set; }


    [Required (ErrorMessage="The Calories field is required")]
    // [Range(0,5000, ErrorMessage ="Must be greater than zero and less than 5,000")]
    [Range(0,5000, ErrorMessage ="Value for {0} must be between {1} and {2}.")]
    public int? Calories { get; set; }


    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;


    [Required]
    [Display(Name = "Name of Chef")]
    [Range(0, int.MaxValue , ErrorMessage ="The Name of Chef field is required")]
    public int ChefId {get; set;}

    public Chef? Author {get; set;}


}


