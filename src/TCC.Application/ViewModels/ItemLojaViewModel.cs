using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TCC.Application.ViewModels
{
    public class ItemLojaViewModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string ImagemUrl { get; set; }
        public string Descricao { get; set; }
        public int Preco { get; set; }
        public long Duracao { get; set; }
    }
}
