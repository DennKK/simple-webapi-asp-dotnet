using webapp.api.Service.Platform;

namespace webapp.api.Service;

public static class ServiceCollectionExtensions
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IPlatformService, PlatformService>();
    }
}
