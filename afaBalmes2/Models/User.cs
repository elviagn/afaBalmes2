using System.ComponentModel.DataAnnotations;

namespace afaBalmes2.Models;

public class User
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? Email { get; set; }
    [Required]
    [Display(Name = "Data alta")]
    [DataType(DataType.Date)] 
    public DateTime Date { get; set; }
    [Required]
    [Display(Name = "Permisos")]
    public UserRole Role { get; set; }
    [Required]
    [Display(Name = "Estat")]
    public Status Status { get; set; }
}

public enum UserRole
{
    Read = 0,
    Write = 1
}

public enum Status
{
    Pending = 0,
    Active = 1
}