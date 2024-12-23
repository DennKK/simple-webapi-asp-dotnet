using webapp.Api.Dto.platform;

namespace webapp.Api.Service.Platform;

public interface IPlatformService
{
    List<PlatformDto> GetAllPlatforms();
    PlatformDto GetPlatform(int id);
    PlatformDto CreatePlatform(CreatePlatformDto createPlatformDto);
    PlatformDto UpdatePlatform(int id, UpdatePlatformDto updatePlatformDto);
}
