using AutoMapper;
using webapp.Api.Dto.Subscription;
using webapp.Api.Model;

namespace webapp.api.Service.Mapper;

public class SubscriptionMappingProfile : Profile
{
    public SubscriptionMappingProfile()
    {
        CreateMap<SubscriptionDto, Subscription>();
        CreateMap<Subscription, SubscriptionDto>();
        CreateMap<CreateSubscriptionDto, Subscription>();
        CreateMap<Subscription, SubscriptionDto>();
        CreateMap<UpdateSubscriptionDto, Subscription>();
    }
}
