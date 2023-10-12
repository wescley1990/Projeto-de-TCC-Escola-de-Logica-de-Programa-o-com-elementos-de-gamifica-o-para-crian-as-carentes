using AutoMapper;
using TCC.Application.Interfaces;
using TCC.Application.ViewModels;
using TCC.Domain.Interfaces;
using TCC.Domain.Models;

namespace TCC.Application.Services;

public class ItemLojaAppService : IItemLojaAppService
{
    private readonly IItemLojaRepository _itemLojaRepository;
    private readonly IMapper _mapper;
    private readonly IUsuarioAppService _userAppService;

    public ItemLojaAppService(
        IItemLojaRepository itemLojaRepository,
        IMapper mapper,
        IUsuarioAppService userAppService
    )
    {
        _userAppService = userAppService;
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

    public async Task<OperationResultViewModel> ComprarItem(Guid id)
    {
        var result = new OperationResultViewModel();

        var user = await _userAppService.GetCurrentUser();
        var item = await _itemLojaRepository.GetById(id);

        if (item is null)
        {
            result = new OperationResultViewModel("Item não encontrado.");
        }

        if (user.QtdMoedas < item.Preco)
        {
            result = new OperationResultViewModel("Quantidade de moedas inferior ao preço do item.");
        }

        return result;
    }
}