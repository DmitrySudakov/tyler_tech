using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TylerTech.Core.Integrations.EfmClient;

namespace TylerTech.Core;

public static class CoreServiceCollectionExtensions
{
    public static IServiceCollection AddCoreServices(
        this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<IEfmClient, EfmClient>();
        services.Configure<EfmClientSettings>(configuration.GetSection("Integrations:Efm"));

        return services;
    }
}
