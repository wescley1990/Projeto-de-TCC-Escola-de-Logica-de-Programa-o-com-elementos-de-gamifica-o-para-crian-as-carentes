using NetDevPack.Domain;
using TCC.Domain.Enums;
namespace TCC.Domain.Models;

public class Curso : Entity, IAggregateRoot
{
    public Curso(
        Guid id, 
        string nome,
        string descricao,
        Nivel nivel
        )
    {
        Id = id;
        Nome = nome;
        Descricao = descricao;
        NivelCurso = nivel;
    }
    
    protected Curso() { }
    
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public Nivel NivelCurso { get; set; }
    public long Duracao { get; set; }
    public IEnumerable<Aula> Aulas { get; set; }
    public int Xp { get; set; }
    public int QtdMoeda { get; set; }

    public string IconUrl { get; set; }
}
