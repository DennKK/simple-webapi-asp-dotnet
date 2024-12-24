using webapp.Api.Repository.Platform;
using webapp.Api.Repository.Subscription;

namespace webapp.Api.Repository;

public static class RepositoryRegistration
{
    public static void AddApplicationRepositories(this IServiceCollection services)
    {
        services.AddScoped<IPlatformRepository, PlatformRepository>();
        services.AddScoped<ISubscriptionRepository, SubscriptionRepository>();
    }
}
