using System.ComponentModel.DataAnnotations;

namespace webapp.Api.Dto;

public record PlatformDto(
    int Id,
    [MaxLength(100)] string Name,
    [MaxLength(100)] string Description,
    List<SubscriptionPlanDto> SubscriptionPlans
);
