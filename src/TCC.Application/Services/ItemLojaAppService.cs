using AutoMapper;
using TCC.Application.Interfaces;
using TCC.Application.ViewModels;
using TCC.Domain.Interfaces;

namespace TCC.Application.Services;

public class ItemLojaAppService : IItemLojaAppService
{
    private readonly IItemLojaRepository _itemLojaRepository;
    private readonly IMapper _mapper;

    public ItemLojaAppService(
        IItemLojaRepository itemLojaRepository,
        IMapper mapper
    )
    {
        _itemLojaRepository = itemLojaRepository;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<ItemLojaViewModel>> GetAll()
    {
        return _mapper.Map<IEnumerable<ItemLojaViewModel>>(await _itemLojaRepository.GetAll());
    }
    
    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
}