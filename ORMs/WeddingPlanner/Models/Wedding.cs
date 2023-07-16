#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models;



public class Wedding
{
    [Key]
    public int? WeddingId { get; set; }

    [Required]
    [Display(Name = "Wedder One")]
    public string WedderOne { get; set; }

    [Required]
    [Display(Name = "Wedder Two")]
    public string WedderTwo { get; set; }

    [Required]
    [CantBePast]
    public DateTime? Date { get; set; }

    [Required]
    public string Address { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;


    // -------FK-------
    public int UserId { get; set; }

    public List<WeddingRsvp> Guests { get; set; } = new List<WeddingRsvp>();

}



public class CantBePastAttribute : ValidationAttribute
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
        if (Diff <= 0)
        {
            return new ValidationResult("Date must be in the future!");
        }
        return ValidationResult.Success;
    }
}