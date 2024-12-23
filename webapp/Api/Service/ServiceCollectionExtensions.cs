using webapp.Api.Service.Platform;

namespace webapp.Api.Service;

public static class ServiceCollectionExtensions
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IPlatformService, PlatformService>();
    }
}
