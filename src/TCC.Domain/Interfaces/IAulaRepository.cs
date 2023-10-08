using NetDevPack.Data;
using TCC.Domain.Models;

namespace TCC.Domain.Interfaces
{
    public interface IAulaRepository : IRepository<Aula>
    {
        Task<Aula> GetById(Guid id);
        Task<IEnumerable<Aula>> GetAll();
        Task<bool> Add(Aula aula);
        void Update(Aula aula);
        void Remove(Aula aula);
        Task<Aula> GetByName(string name);
    }
}
