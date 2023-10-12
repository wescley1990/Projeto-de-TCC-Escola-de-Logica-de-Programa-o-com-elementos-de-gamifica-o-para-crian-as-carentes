using NetDevPack.Domain;
using System.Numerics;

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
        public long Duracao { get; set; }
        public decimal Multiplicador { get; set; }
        public long QtdXp { get; set; }
    }
}
