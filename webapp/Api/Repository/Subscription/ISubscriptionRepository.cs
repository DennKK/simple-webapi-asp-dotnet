namespace webapp.Api.Repository.Subscription;

public interface ISubscriptionRepository
{
    Task<List<Model.Subscription>> GetAllSubscriptionsAsync();
    Task<Model.Subscription?> GetSubscriptionByIdAsync(int id);
    Task AddSubscriptionAsync(Model.Subscription subscription);
    Task UpdateSubscriptionAsync(Model.Subscription subscription);
    Task DeleteSubscriptionAsync(Model.Subscription subscription);
}
