using AutoMapper;
using webapp.Api.Dto.Platform;
using webapp.Api.Model;

namespace webapp.api.Service.Mapper;

public class PlatformMappingProfile : Profile
{
    public PlatformMappingProfile()
    {
        CreateMap<PlatformDto, Platform>();
        CreateMap<Platform, PlatformDto>();
        CreateMap<CreatePlatformDto, Platform>();
        CreateMap<UpdatePlatformDto, Platform>();
    }
}
