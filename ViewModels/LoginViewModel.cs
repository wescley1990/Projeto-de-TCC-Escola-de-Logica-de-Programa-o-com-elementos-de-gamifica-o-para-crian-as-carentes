namespace TCC.ViewModels;
using System.ComponentModel.DataAnnotations;

public class LoginViewModel
{
    [Required(ErrorMessage = "O campo Nome de Usuário é obrigatório.")]
    [Display(Name = "Nome de Usuário")]
    public string UserName { get; set; }

    [Required(ErrorMessage = "O campo Senha é obrigatório.")]
    [DataType(DataType.Password)]
    [Display(Name = "Senha")]
    public string Password { get; set; }
}
