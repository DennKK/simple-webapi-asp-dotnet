using webapp.api.Data;

namespace webapp.api.Service.Platform;

public class PlatformService(ApplicationDbContext dbContext) : IPlatformService
{
    public List<Model.Platform> GetAllPlatforms()
    {
        return dbContext.Platforms.ToList();
    }

    public Model.Platform GetPlatform(int id)
    {
        return dbContext.Platforms.Find(id) ?? throw new InvalidOperationException();
    }
}
