using AutoMapper;
using webapp.Api.Dto;
using webapp.Api.Model;

namespace webapp.api.Service.Mapper;

public class SubscriptionPlanMappingProfile : Profile
{
    public SubscriptionPlanMappingProfile()
    {
        CreateMap<SubscriptionPlanDto, SubscriptionPlan>();
        CreateMap<SubscriptionPlan, SubscriptionPlanDto>();
    }
}
