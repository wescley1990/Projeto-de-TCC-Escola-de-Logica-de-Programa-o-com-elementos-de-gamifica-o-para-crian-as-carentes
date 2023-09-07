using TCC.Application.ViewModels;

namespace TCC.Application.Interfaces;

public interface ICursoAppService : IDisposable
{
    Task<IEnumerable<CursoViewModel>> GetAll();
}