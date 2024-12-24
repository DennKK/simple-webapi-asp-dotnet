using Microsoft.EntityFrameworkCore;
using webapp.Api.Data;

namespace webapp.Api.Repository.Subscription;

public class SubscriptionRepository(ApplicationDbContext dbContext) : ISubscriptionRepository
{
    public async Task<List<Model.Subscription>> GetAllSubscriptionsAsync()
    {
        return await dbContext.Subscriptions.ToListAsync();
    }

    public async Task<Model.Subscription?> GetSubscriptionByIdAsync(int id)
    {
        return await dbContext.Subscriptions.FindAsync(id);
    }

    public async Task AddSubscriptionAsync(Model.Subscription subscription)
    {
        dbContext.Subscriptions.Add(subscription);
        await dbContext.SaveChangesAsync();
    }

    public async Task UpdateSubscriptionAsync(Model.Subscription subscription)
    {
        dbContext.Subscriptions.Update(subscription);
        await dbContext.SaveChangesAsync();
    }

    public async Task DeleteSubscriptionAsync(Model.Subscription subscription)
    {
        dbContext.Subscriptions.Remove(subscription);
        await dbContext.SaveChangesAsync();
    }
}
