using TCC.Domain.Enums;
namespace TCC.Domain.Models;

public class Curso
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public Nivel NivelCurso { get; set; }
    public long Duracao { get; set; }
}
