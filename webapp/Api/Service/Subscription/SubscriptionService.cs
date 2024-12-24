using AutoMapper;
using webapp.Api.Dto.Subscription;
using webapp.Api.Repository.Subscription;
using webapp.Api.Service.Platform;

namespace webapp.Api.Service.Subscription;

public class SubscriptionService(
    ISubscriptionRepository repository,
    IPlatformService platformService,
    IMapper mapper) : ISubscriptionService
{
    public async Task<List<SubscriptionDto>> GetAllSubscriptions()
    {
        var subscriptions = await repository.GetAllSubscriptionsAsync();
        return mapper.Map<List<SubscriptionDto>>(subscriptions);
    }

    public async Task<SubscriptionDto> GetSubscription(int id)
    {
        var subscription = await FindSubscriptionById(id);
        return mapper.Map<SubscriptionDto>(subscription);
    }

    public async Task<SubscriptionDto> CreateSubscription(CreateSubscriptionDto createSubscriptionDto)
    {
        await platformService.GetPlatform(createSubscriptionDto.PlatformId);

        var subscription = mapper.Map<Model.Subscription>(createSubscriptionDto);
        await repository.AddSubscriptionAsync(subscription);
        return mapper.Map<SubscriptionDto>(subscription);
    }

    public async Task<SubscriptionDto> UpdateSubscription(int id, UpdateSubscriptionDto updateSubscriptionDto)
    {
        var subscription = await FindSubscriptionById(id);
        mapper.Map(updateSubscriptionDto, subscription);
        await repository.UpdateSubscriptionAsync(subscription);
        return mapper.Map<SubscriptionDto>(subscription);
    }

    public async Task DeleteSubscription(int id)
    {
        var platform = await FindSubscriptionById(id);
        await repository.DeleteSubscriptionAsync(platform);
    }

    private async Task<Model.Subscription> FindSubscriptionById(int id)
    {
        return await repository.GetSubscriptionByIdAsync(id) ??
               throw new InvalidOperationException($"Subscription with id {id} does not exist.");
    }
}
