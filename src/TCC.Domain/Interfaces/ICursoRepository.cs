using NetDevPack.Data;
using TCC.Domain.Models;

namespace TCC.Domain.Interfaces
{
    public interface ICursoRepository : IRepository<Curso>
    {
        Task<Curso> GetById(Guid id);
        Task<IEnumerable<Curso>> GetAll();

        void Add(Curso curso);
        void Update(Curso curso);
        void Remove(Curso curso);

        Task<Curso> GetByName(string name);
    }
}
