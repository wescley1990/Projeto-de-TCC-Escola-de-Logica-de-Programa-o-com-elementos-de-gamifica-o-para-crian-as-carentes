using NetDevPack.Data;
using TCC.Domain.Models;

namespace TCC.Domain.Interfaces
{
    public interface ICursoRepository : IRepository<Curso>
    {
        Task<Curso> GetById(Guid id);
        Task<IEnumerable<Curso>> GetAll();

        Task<bool> Add(Curso curso);
        void Update(Curso curso);
        Task<bool> Remove(Curso curso);

        Task<Curso> GetByName(string name);
    }
}
