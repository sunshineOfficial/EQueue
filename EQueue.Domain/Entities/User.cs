using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace EQueue.Domain.Entities;

public class User : IdentityUser
{
    [Required] public string Name { get; set; } = "";
    [Required] public string Surname { get; set; } = "";
    public string? Patronymic { get; set; }
    public DateTime? Birthday { get; set; }
    [Required] public DateTime RegistrationDate { get; set; }
}