using TCC.Application.ViewModels;

namespace TCC.Application.Interfaces;

public interface IItemLojaAppService : IDisposable
{
    Task<IEnumerable<ItemLojaViewModel>> GetAll();
}