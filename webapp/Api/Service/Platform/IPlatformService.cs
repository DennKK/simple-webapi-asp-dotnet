using webapp.Api.Dto;

namespace webapp.Api.Service.Platform;

public interface IPlatformService
{
    List<PlatformDto> GetAllPlatforms();
    PlatformDto GetPlatform(int id);
}
