namespace webapp.Api.Repository.Platform;

public interface IPlatformRepository
{
    Task<List<Model.Platform>> GetAllPlatformsAsync();
    Task<Model.Platform?> GetPlatformByIdAsync(int id);
    Task AddPlatformAsync(Model.Platform platform);
    Task UpdatePlatformAsync(Model.Platform platform);
    Task DeletePlatformAsync(Model.Platform platform);
}
