using NetDevPack.Domain;

namespace TCC.Domain.Models
{
    public class Usuario : Entity, IAggregateRoot
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int NivelXp { get; set; }
        public List<ItemLoja> ItensAdquiridos { get; set; }
    }
}
