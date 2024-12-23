namespace webapp.Api.Dto.platform;

public record PlatformDto(
    int Id,
    string Name,
    string Description,
    List<SubscriptionPlanDto> SubscriptionPlans
);
