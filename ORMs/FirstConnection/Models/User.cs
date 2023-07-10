
namespace FirstConnection.Models;
using System.ComponentModel.DataAnnotations;
#pragma warning disable CS8618

public class User
{
    [Key]
    public int UserId { get; set; }
    public string FirstName { get; set; } 
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
