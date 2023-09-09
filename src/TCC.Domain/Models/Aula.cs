using NetDevPack.Domain;

namespace TCC.Domain.Models
{
    public class Aula : Entity, IAggregateRoot
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

    }
}
