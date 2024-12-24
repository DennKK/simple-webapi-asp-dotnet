using webapp.Api.Dto.Subscription;

namespace webapp.Api.Dto.Platform;

public record PlatformDto(
    int Id,
    string Name,
    string Description,
    List<SubscriptionDto> subscriptions
);
