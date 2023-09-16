using Microsoft.Extensions.DependencyInjection;
using TCC.Application.Interfaces;
using TCC.Application.Services;
using TCC.Domain.Interfaces;
using TCC.Infra.Data.Context;
using TCC.Infra.Data.Repository;

namespace TCC.Infra.CrossCutting.IoC;

public static class NativeInjector
{
    public static void RegisterServices(IServiceCollection services)
    {
        // Application
        services.AddScoped<ICursoAppService, CursoAppService>();
        
        // Infra - Data
        services.AddScoped<ICursoRepository, CursoRepository>();
        services.AddScoped<ItemLojaRepository, ItemLojaRepository>();
        services.AddScoped<AppDbContext>();
    }
}