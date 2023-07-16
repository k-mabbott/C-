
#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models;


[NotMapped]
public class LoginUser
{
    [Required]
    [Display(Name ="Email")]
    [DataType(DataType.EmailAddress)]
    [RegularExpression(@"^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$", ErrorMessage = "Invalid email format")]
    public string LoginEmail { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name ="Password")]
    [MinLength(8, ErrorMessage ="Password must be at least 8 characters")]

    public string LoginPassword { get; set; }
}

