using AutoMapper;
using TCC.Application.Interfaces;
using TCC.Application.ViewModels;
using TCC.Domain.Enums;
using TCC.Domain.Interfaces;
using TCC.Domain.Models;

namespace TCC.Application.Services;

public class CursoAppService : ICursoAppService
{
    //private readonly ICursoRepository _cursoRepository;
    private readonly IMapper _mapper;
    
    public CursoAppService(
        IMapper mapper
        )
    {
        //_cursoRepository = cursoRepository;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<CursoViewModel>> GetAll()
    {
        var result = new List<Curso>
        {
            new Curso(Guid.NewGuid(), "Teste1", "Curso teste 1", Nivel.Iniciante),
            new Curso(Guid.NewGuid(), "Teste2", "Curso teste 2", Nivel.Intermediario),
            new Curso(Guid.NewGuid(), "Teste3", "Curso teste 3", Nivel.Iniciante),
            new Curso(Guid.NewGuid(), "Teste4", "Curso teste 4", Nivel.Avancado),
            new Curso(Guid.NewGuid(), "Teste5", "Curso teste 5", Nivel.Iniciante),
        };
        return _mapper.Map<IEnumerable<CursoViewModel>>(result);
    }
    
    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}