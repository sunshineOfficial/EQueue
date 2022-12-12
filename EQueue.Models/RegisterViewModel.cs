using System.ComponentModel.DataAnnotations;

namespace EQueue.Models;

public class RegisterViewModel
{
    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public string Email { get; set; }
    
    [Required]
    [Display(Name = "Имя")]
    public string Name { get; set; }
    
    [Required]
    [Display(Name = "Фамилия")]
    public string Surname { get; set; }
    
    [Display(Name = "Отчество")]
    public string Patronymic { get; set; }
    
    [DataType(DataType.Date)]
    [Display(Name = "Дата рождения")]
    public DateTime? Birthday { get; set; }
    
    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Пароль")]
    public string Password { get; set; }
    
    [Required]
    [Compare("Password", ErrorMessage = "Пароли не совпадают")]
    [DataType(DataType.Password)]
    [Display(Name = "Подтвердить пароль")]
    public string PasswordConfirm { get; set; }
}