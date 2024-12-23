using AutoMapper;
using webapp.Api.Dto;
using webapp.Api.Model;

namespace webapp.api.Service.Mapper;

public class UserMappingProfile : Profile
{
    public UserMappingProfile()
    {
        CreateMap<User, UserDto>();
        CreateMap<UserDto, User>();
    }
}
