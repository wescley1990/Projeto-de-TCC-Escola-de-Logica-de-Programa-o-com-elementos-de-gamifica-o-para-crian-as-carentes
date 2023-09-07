using TCC.Application.ViewModels;

namespace TCC.Application.Interfaces;

public interface ICursoAppService
{
    Task<IEnumerable<CursoViewModel>> GetAll();
}