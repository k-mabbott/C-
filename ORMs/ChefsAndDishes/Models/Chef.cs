#pragma warning disable CS8618

namespace ChefsAndDishes.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


public class Chef
{
    [Key]
    public int ChefId { get; set; }

    [Required]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Required]
    [MustBe18]
    [Display(Name = "Date of Birth")]
    public DateTime? DoB { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public List<Dish>? AllDishes { get; set; } = new List<Dish>();

}

public class CantBeFutureAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {

        if (value == null)
        {
            return new ValidationResult("Date of Birth must be provided!");
        }

        DateTime Curr = DateTime.Today;
        int Diff = DateTime.Compare((DateTime)value, Curr);
        // Console.WriteLine(Diff);
        if (Diff >= 0)
        {
            return new ValidationResult("Date of Birth must be in the past!");
        }
        return ValidationResult.Success;
    }
}

public class MustBe18 : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {

        if (value == null)
        {
            return new ValidationResult("Date of Birth must be provided!");
        }

        var age = GetAge((DateTime)value);
        if (age < 18)
        {
            return new ValidationResult("Must be at least 18 years old!");
        }
        return ValidationResult.Success;
    }


    int GetAge(DateTime bornDate)
    {
        DateTime today = DateTime.Today;
        int age = today.Year - bornDate.Year;
        if (bornDate > today.AddYears(-age))
        {
            age--;
        }
        return age;
    }
}