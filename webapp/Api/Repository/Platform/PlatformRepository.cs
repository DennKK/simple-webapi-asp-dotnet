using Microsoft.EntityFrameworkCore;
using webapp.Api.Data;

namespace webapp.Api.Repository.Platform;

public class PlatformRepository(ApplicationDbContext dbContext) : IPlatformRepository
{
    public async Task<List<Model.Platform>> GetAllPlatformsAsync()
    {
        return await dbContext.Platforms
            .Include(p => p.Subscriptions)
            .ToListAsync();
    }

    public async Task<Model.Platform?> GetPlatformByIdAsync(int id)
    {
        return await dbContext.Platforms
            .Include(p => p.Subscriptions)
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task AddPlatformAsync(Model.Platform platform)
    {
        dbContext.Platforms.Add(platform);
        await dbContext.SaveChangesAsync();
    }

    public async Task UpdatePlatformAsync(Model.Platform platform)
    {
        dbContext.Platforms.Update(platform);
        await dbContext.SaveChangesAsync();
    }

    public async Task DeletePlatformAsync(Model.Platform platform)
    {
        dbContext.Platforms.Remove(platform);
        await dbContext.SaveChangesAsync();
    }
}
