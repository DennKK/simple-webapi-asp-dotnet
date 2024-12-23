namespace webapp.Api.Dto;

public record SubscriptionPlanDto(
    int Id,
    string Name,
    decimal Price,
    string Duration,
    string Features
);
