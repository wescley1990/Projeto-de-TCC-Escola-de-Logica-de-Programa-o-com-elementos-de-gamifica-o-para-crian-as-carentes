using NetDevPack.Domain;

namespace TCC.Domain.Models
{
    public class PedidoLoja : Entity, IAggregateRoot
    {
        public PedidoLoja()
        {

        }

        public DateTime Timestamp { get; set; }
        public ItemLoja ItemComprado { get; set; }
    }
}
