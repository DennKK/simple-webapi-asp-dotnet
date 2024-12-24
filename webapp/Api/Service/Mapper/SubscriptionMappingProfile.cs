using AutoMapper;
using webapp.Api.Dto;
using webapp.Api.Model;

namespace webapp.api.Service.Mapper;

public class SubscriptionMappingProfile : Profile
{
    public SubscriptionMappingProfile()
    {
        CreateMap<SubscriptionDto, Subscription>();
        CreateMap<Subscription, SubscriptionDto>();
    }
}
