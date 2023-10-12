using NetDevPack.Domain;

namespace TCC.Domain.Models
{
    public class ItemLoja : Entity, IAggregateRoot
    {
        public ItemLoja()
        {
            
        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string ImagemUrl { get; set; }
        public int Preco { get; set; }
        public TimeSpan Duracao { get; set; }
    }
}
