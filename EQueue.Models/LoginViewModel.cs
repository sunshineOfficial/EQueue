using System.ComponentModel.DataAnnotations;

namespace EQueue.Models;

public class LoginViewModel
{
    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public string Email { get; set; }
    
    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Пароль")]
    public string Password { get; set; }
    
    [Display(Name = "Запомнить меня")]
    public bool RememberMe { get; set; }
    
    public string? ReturnUrl { get; set; }
}