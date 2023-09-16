using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TCC.Application.ViewModels
{
    public class ItemLojaViewModel
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "O nome é obrigatório!")]
        [MinLength(2)]
        [MaxLength(100)]
        [DisplayName("Nome")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "O endereço da imagem é obrigatório!")]
        public string ImagemUrl { get; set; }
        
        [Required(ErrorMessage = "O preço é obrigatório!")]
        public int Preco { get; set; }
        
        [Required(ErrorMessage = "A validade é obrigatória!")]
        public DateTime ValidadeInicio { get; set; }
        
        [Required(ErrorMessage = "A validade é obrigatória!")]
        public DateTime ValidadeFim { get; set; }
    }
}
