using webapp.Api.Dto.platform;

namespace webapp.Api.Service.Platform;

public interface IPlatformService
{
    Task<List<PlatformDto>> GetAllPlatforms();
    Task<PlatformDto> GetPlatform(int id);
    Task<PlatformDto> CreatePlatform(CreatePlatformDto createPlatformDto);
    Task<PlatformDto> UpdatePlatform(int id, UpdatePlatformDto updatePlatformDto);
    Task DeletePlatform(int id);
}
