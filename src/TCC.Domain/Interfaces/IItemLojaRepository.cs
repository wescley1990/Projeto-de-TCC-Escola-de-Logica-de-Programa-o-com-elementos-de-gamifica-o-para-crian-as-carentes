using NetDevPack.Data;
using TCC.Domain.Models;

namespace TCC.Domain.Interfaces
{
    public interface IItemLojaRepository : IRepository<ItemLoja>
    {
        Task<ItemLoja> GetById(Guid id);
        Task<IEnumerable<ItemLoja>> GetAll();

        void Add(ItemLoja item);
        void Update(ItemLoja item);
        void Remove(ItemLoja item);
    }
}
