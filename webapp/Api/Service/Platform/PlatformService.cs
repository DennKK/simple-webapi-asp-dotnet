using AutoMapper;
using webapp.Api.Data;
using webapp.Api.Dto.platform;

namespace webapp.Api.Service.Platform;

public class PlatformService(ApplicationDbContext dbContext, IMapper mapper) : IPlatformService
{
    public List<PlatformDto> GetAllPlatforms()
    {
        var platforms = dbContext.Platforms.ToList();
        return mapper.Map<List<PlatformDto>>(platforms);
    }

    public PlatformDto GetPlatform(int id)
    {
        var platform = FindPlatformById(id);
        return mapper.Map<PlatformDto>(platform);
    }

    public PlatformDto CreatePlatform(CreatePlatformDto createPlatformDto)
    {
        var platform = mapper.Map<Model.Platform>(createPlatformDto);
        dbContext.Platforms.Add(platform);
        dbContext.SaveChanges();

        return mapper.Map<PlatformDto>(platform);
    }

    public PlatformDto UpdatePlatform(int id, UpdatePlatformDto updatePlatformDto)
    {
        var platform = FindPlatformById(id);
        mapper.Map(updatePlatformDto, platform);
        dbContext.SaveChanges();

        return mapper.Map<PlatformDto>(platform);
    }

    public void DeletePlatform(int id)
    {
        var platform = FindPlatformById(id);
        dbContext.Platforms.Remove(platform);
        dbContext.SaveChanges();
    }

    private Model.Platform FindPlatformById(int id)
    {
        return dbContext.Platforms.Find(id) ??
               throw new InvalidOperationException($"Platform with id {id} does not exist.");
    }
}
