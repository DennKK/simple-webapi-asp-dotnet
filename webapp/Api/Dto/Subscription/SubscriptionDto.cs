namespace webapp.Api.Dto.Subscription;

public record SubscriptionDto(
    int Id,
    int PlatformId,
    string Name,
    decimal Price,
    DateTime StartDate,
    DateTime? EndDate,
    bool IsActive
);
