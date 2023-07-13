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
    [CantBeFuture]
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
        DateTime Val = (DateTime)value;
        DateTime Curr = DateTime.Today;
        DateTime tmp = Curr;
        // DateTime dt_18 = Val.AddYears(-18);

        // if (Val.Date >= dt_18.Date)
        // {
        //     return new ValidationResult("Must be at least 18 years old!");
        // }
        // DateTime tmp = Val;
        int years = -1;
        while (Val < Curr)
        {
            years++;
            tmp = tmp.AddYears(1);
        }
        // int age = 0;
        // age = DateTime.Today.AddYears(-Val.Year).Year;
        if (years < 18)
        {
            return new ValidationResult("Must be at least 18 years old!");
        }
        return ValidationResult.Success;
    }
}