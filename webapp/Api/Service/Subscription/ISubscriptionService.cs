using webapp.Api.Dto.Subscription;

namespace webapp.Api.Service.Subscription;

public interface ISubscriptionService
{
    Task<List<SubscriptionDto>> GetAllSubscriptions();
    Task<SubscriptionDto> GetSubscription(int id);
    Task<SubscriptionDto> CreateSubscription(CreateSubscriptionDto createSubscriptionDto);
    Task<SubscriptionDto> UpdateSubscription(int id, UpdateSubscriptionDto updateSubscriptionDto);
    Task DeleteSubscription(int id);
}
