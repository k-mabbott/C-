using System.ComponentModel.DataAnnotations;
namespace DateValidator.Models;


public class NewDate
{
    [Required]
    public DateTime MyDate {get; set;} = DateTime.Now;

}