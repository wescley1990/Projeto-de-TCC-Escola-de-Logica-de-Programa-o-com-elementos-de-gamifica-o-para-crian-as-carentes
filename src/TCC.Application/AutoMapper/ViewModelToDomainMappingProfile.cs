using AutoMapper;
using TCC.Application.ViewModels;

namespace TCC.Application.AutoMapper;

public class ViewModelToDomainMappingProfile : Profile
{
    public ViewModelToDomainMappingProfile()
    {
        // CreateMap<CursoViewModel, RegisterNewCustomerCommand>()
        //     .ConstructUsing(c => new RegisterNewCustomerCommand(c.Name, c.Email, c.BirthDate));
        // CreateMap<CursoViewModel, UpdateCustomerCommand>()
        //     .ConstructUsing(c => new UpdateCustomerCommand(c.Id, c.Name, c.Email, c.BirthDate));
    }
}