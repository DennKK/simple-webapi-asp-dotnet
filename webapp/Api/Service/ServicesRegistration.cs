using webapp.Api.Service.Platform;
using webapp.Api.Service.Subscription;

namespace webapp.Api.Service;

public static class ServicesRegistration
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IPlatformService, PlatformService>();
        services.AddScoped<ISubscriptionService, SubscriptionService>();
    }
}
