using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TCC.Domain.Enums;

public enum Nivel
{
    [Display(Name = "Iniciante")]
    Iniciante = 1,
    
    [Display(Name = "Intermediário")]
    Intermediario = 2,
    
    [Display(Name = "Avançado")]
    Avancado = 3
}
