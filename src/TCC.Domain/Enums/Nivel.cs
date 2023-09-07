using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TCC.Domain.Enums;

public enum Nivel
{
    [Display(Name = "Iniciante")]
    Iniciante,
    
    [Display(Name = "Intermediário")]
    Intermediario,
    
    [Display(Name = "Avançado")]
    Avancado
}
