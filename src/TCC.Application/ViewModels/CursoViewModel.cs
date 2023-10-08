using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TCC.Domain.Enums;

namespace TCC.Application.ViewModels
{
    public class CursoViewModel
    {
        [Key]
        [DisplayName("Id")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório!")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Nome")]
        public string Nome { get; set; }
        
        [DisplayName("Descrição")]
        public string Descricao { get; set; }
        
        public Nivel NivelCurso { get; set; }
        
        public long Duracao { get; set; }

        public List<AulaViewModel> Aulas { get; set; }

        public int Xp { get; set; }
        public int QtdMoeda { get; set; }

        public string IconUrl { get; set; }
    }
}
