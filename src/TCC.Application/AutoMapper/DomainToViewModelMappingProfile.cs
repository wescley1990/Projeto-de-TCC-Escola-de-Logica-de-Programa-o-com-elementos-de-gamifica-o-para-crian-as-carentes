using AutoMapper;
using Microsoft.AspNetCore.Identity;
using TCC.Application.ViewModels;
using TCC.Domain.Models;

namespace TCC.Application.AutoMapper;

public class DomainToViewModelMappingProfile : Profile
{
    public DomainToViewModelMappingProfile()
    {
        CreateMap<Curso, CursoViewModel>();
        CreateMap<ItemLoja, ItemLojaViewModel>();
        CreateMap<Usuario, UsuarioViewModel>();
    }
}