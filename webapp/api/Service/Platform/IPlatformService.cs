namespace webapp.api.Service.Platform;

public interface IPlatformService
{
    List<Model.Platform> GetAllPlatforms();
    Model.Platform GetPlatform(int id);
}
