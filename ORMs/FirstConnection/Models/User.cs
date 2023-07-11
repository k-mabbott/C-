
namespace FirstConnection.Models;
using System.ComponentModel.DataAnnotations;

#pragma warning disable CS8618

public class User
{
    [Key]


    public int UserId { get; set; }

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }

    // [NotMapped]
    // [MinLength(3)]
    // public string? Allen {get; set;}


    public bool Robot { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
