using TCC.Application.ViewModels;

namespace TCC.Application.Interfaces;

public interface ICursoAppService : IDisposable
{
    Task<IEnumerable<CursoViewModel>> GetAll();
    Task<CursoViewModel> GetById(Guid id);

    Task<CursoViewModel> GetByName(string name);
}