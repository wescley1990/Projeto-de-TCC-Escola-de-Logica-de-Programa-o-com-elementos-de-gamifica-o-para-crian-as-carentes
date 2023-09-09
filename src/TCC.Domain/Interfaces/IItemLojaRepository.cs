using NetDevPack.Data;
using TCC.Domain.Models;

namespace TCC.Domain.Interfaces
{
    public interface IItemLojaRepository : IRepository<ItemLoja>
    {
        Task<Curso> GetById(Guid id);
        Task<IEnumerable<ItemLoja>> GetAll();

        void Add(ItemLoja curso);
        void Update(ItemLoja curso);
        void Remove(ItemLoja curso);
    }
}
