using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TCC.Domain.Enums;

namespace TCC.Application.ViewModels
{
    public class CursoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório!")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("nome")]
        public string Nome { get; set; }
        
        public string Descricao { get; set; }
        public Nivel NivelCurso { get; set; }
        public long Duracao { get; set; }
    }
}
