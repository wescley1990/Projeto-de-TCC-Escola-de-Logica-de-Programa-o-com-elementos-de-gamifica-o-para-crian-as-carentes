using AutoMapper;
using TCC.Application.Interfaces;
using TCC.Application.ViewModels;
using TCC.Domain.Interfaces;
using TCC.Domain.Models;
using TCC.Infra.Data.Repository;

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

    public async void Add(ItemLojaViewModel item)
    {
        await _itemLojaRepository.Add(_mapper.Map<ItemLoja>(item));
    }

    public async Task<bool> Remove(ItemLojaViewModel item)
    {
        var itemDomain = _mapper.Map<ItemLoja>(item);

        return await _itemLojaRepository.Remove(itemDomain);
    }
}