using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace afaBalmes2.Models;

[Table("User")]
public class User
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? Email { get; set; }
    [Required]
    [Display(Name="Contrasenya")]
    public string? Password { get; set; }
    [Display(Name = "Data alta")]
    public DateTime Date { get; set; }
    [Display(Name = "Permisos")]
    public UserRole Role { get; set; }
    [Display(Name = "Estat")]
    public Status Status { get; set; }
}

public enum UserRole
{
    NoAccess = 0,
    Read = 1,
    Write = 2
}

public enum Status
{
    Pending = 0,
    Active = 1,
    Erased = 2
}