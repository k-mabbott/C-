namespace FormSubmission.Models;
using System.ComponentModel.DataAnnotations;
#pragma warning disable CS8618

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}


public class OnlyOddNumsAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        Console.WriteLine(value);

        if (value == null)
        {
            return new ValidationResult("Date of Birth must be provided!");
        }

        if (((int)value) % 2 == 0)
        {
            return new ValidationResult("Whole odd numbers only please!");
        }
        else
        {
            return ValidationResult.Success;
        }
    }
}

public class MustBePrimeAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value == null)
        {
            return new ValidationResult("Date of Birth must be provided!");
        }

        if (((int)value) <= 1)
        {
            return new ValidationResult("Prime numbers only please!");
        }
        else if (((int)value) == 2)
        {
            return ValidationResult.Success;
        }
        else if (((int)value) % 2 == 0)
        {
            return new ValidationResult("Prime numbers only please!");
        }
        else
        {
            int end = (int)Math.Floor(Math.Sqrt(((int)value)));

            for (int i = 3; i <= end; i++)
            {
                if (((int)value) % i == 0)
                {
                    return new ValidationResult("Prime numbers only please!");
                }
            }
            return ValidationResult.Success;
        }
    }
}

public class MustBePresentAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {

        if (value == null)
        {
            return new ValidationResult("Date of Birth must be provided!");
        }

        DateTime Curr = DateTime.Now;
        int Diff = DateTime.Compare((DateTime)value, Curr);
        // Console.WriteLine(Diff);
        if (Diff > 0)
        {
            return new ValidationResult("Date of Birth must be in the past!");
        }
        else
        {
            return ValidationResult.Success;
        }
    }
}
