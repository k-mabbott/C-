
#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models;

public class User
{
    [Key]
    public int UserId { get; set; }

    [Required]
    [Display(Name = "First Name")]
    [MinLength(2, ErrorMessage ="First name field must be at least 2 characters long.")]
    public string FirstName { get; set; }

    [Required]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Required]
    [UniqueEmail]
    [DataType(DataType.EmailAddress)]
    [RegularExpression(@"^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$", ErrorMessage = "Invalid email format")]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
    public string Password { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    [NotMapped]
    [DataType(DataType.Password)]
    [Display(Name = "Confirm Password")]
    [Compare("Password", ErrorMessage = "Passwords do not match!")]
    public string ConfirmPassword { get; set; }

    public List<WeddingRsvp> Weddings { get; set; } = new List<WeddingRsvp>();


}



public class UniqueEmailAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value == null)
        {
            return new ValidationResult("Email is required!");
        }
        var service = validationContext.GetService(typeof(MyContext));

        if (service is MyContext _context)
        {
            if (_context.Users.Any(e => e.Email == value.ToString()))
            {
                return new ValidationResult("Email must be unique!");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
        else
        {
            throw new InvalidOperationException("Could not retrieve MyContext from ValidationContext");
        }
    }
}
