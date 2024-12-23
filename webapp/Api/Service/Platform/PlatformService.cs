using AutoMapper;
using webapp.Api.Data;
using webapp.Api.Dto;

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
        var platform = dbContext.Platforms.Find(id) ?? throw new InvalidOperationException();
        return mapper.Map<PlatformDto>(platform);
    }
}
