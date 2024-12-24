using webapp.Api.Repository.Platform;

namespace webapp.Api.Repository;

public static class RepositoryRegistration
{
    public static void AddApplicationRepositories(this IServiceCollection services)
    {
        services.AddScoped<IPlatformRepository, PlatformRepository>();
    }
}
