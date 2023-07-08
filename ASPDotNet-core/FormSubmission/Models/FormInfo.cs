
#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace FormSubmission.Models;

public class FormInfo
{
    [Required]
    [MinLength(2, ErrorMessage ="Name must be at least 2 characters long.")]
    public string? Name {get;set;}


    [Required]
    [EmailAddress]
    public string? Email {get;set;}


    [Required(ErrorMessage="Date of Birth is required!")]
    [MustBePresent]
    public DateTime? DateOfBirth {get;set;}


    [Required]
    [DataType(DataType.Password)]
    [MinLength(8, ErrorMessage ="Name must be at least 8 characters long.")]
    public string? Password {get;set;}


    [Required(ErrorMessage="Favorite Prime Number is required!")]
    // [OnlyOddNums]
    [MustBePrime]
    public int? FavOddNum {get;set;}



}

