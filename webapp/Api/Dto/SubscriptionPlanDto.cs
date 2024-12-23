using System.ComponentModel.DataAnnotations;

namespace webapp.Api.Dto;

public record SubscriptionPlanDto(
    int Id,
    [MaxLength(100)] string Name,
    [Range(0, double.MaxValue)] decimal Price,
    [MaxLength(100)] string Duration,
    [MaxLength(100)] string Features
);
