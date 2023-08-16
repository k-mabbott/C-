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


    [Required (ErrorMessage="The Difficulty field is required")]
    [Range(1,5, ErrorMessage ="The Difficulty field is required")]
    public int? Difficulty { get; set; }


    [Required (ErrorMessage="The Calories field is required")]
    [Range(0,8000, ErrorMessage ="Value for {0} must be between {1} and {2}.")]
    public int? Calories { get; set; }

    [Required (ErrorMessage="The Description field is required")]
    [MinLength(15, ErrorMessage ="That can't be long enough to describe it...")]
    public string Description { get; set; }


    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;


    [Required]
    [Display(Name = "Name of Chef")]
    [Range(0, int.MaxValue , ErrorMessage ="The Name of Chef field is required")]
    public int ChefId {get; set;}

    public Chef? Author {get; set;}


}


