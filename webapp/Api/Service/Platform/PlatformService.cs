using AutoMapper;
using webapp.Api.Dto.Platform;
using webapp.Api.Repository.Platform;

namespace webapp.Api.Service.Platform;

public class PlatformService(IPlatformRepository repository, IMapper mapper) : IPlatformService
{
    public async Task<List<PlatformDto>> GetAllPlatforms()
    {
        var platforms = await repository.GetAllPlatformsAsync();
        return mapper.Map<List<PlatformDto>>(platforms);
    }

    public async Task<PlatformDto> GetPlatform(int id)
    {
        var platform = await FindPlatformById(id);
        return mapper.Map<PlatformDto>(platform);
    }

    public async Task<PlatformDto> CreatePlatform(CreatePlatformDto createPlatformDto)
    {
        var platform = mapper.Map<Model.Platform>(createPlatformDto);
        await repository.AddPlatformAsync(platform);
        return mapper.Map<PlatformDto>(platform);
    }

    public async Task<PlatformDto> UpdatePlatform(int id, UpdatePlatformDto updatePlatformDto)
    {
        var platform = await FindPlatformById(id);
        mapper.Map(updatePlatformDto, platform);
        await repository.UpdatePlatformAsync(platform);
        return mapper.Map<PlatformDto>(platform);
    }

    public async Task DeletePlatform(int id)
    {
        var platform = await FindPlatformById(id);
        await repository.DeletePlatformAsync(platform);
    }

    private async Task<Model.Platform> FindPlatformById(int id)
    {
        return await repository.GetPlatformByIdAsync(id) ??
               throw new InvalidOperationException($"Platform with id {id} does not exist.");
    }
}
