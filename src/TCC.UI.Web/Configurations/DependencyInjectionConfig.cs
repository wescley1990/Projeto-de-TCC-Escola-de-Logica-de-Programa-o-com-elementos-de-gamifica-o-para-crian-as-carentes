namespace TCC.UI.Web.Configurations;
using TCC.Infra.CrossCutting.IoC;

public static class DependencyInjectionConfig
{
    public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
    {
        if (services == null) throw new ArgumentNullException(nameof(services));

        NativeInjector.RegisterServices(services);
    }
}