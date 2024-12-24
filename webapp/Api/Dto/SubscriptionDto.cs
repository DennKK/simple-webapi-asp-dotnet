namespace webapp.Api.Dto;

public record SubscriptionDto(
    int Id,
    string Name,
    decimal Price,
    DateTime StartDate,
    DateTime EndDate,
    string Status
);
