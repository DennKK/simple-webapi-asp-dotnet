using Microsoft.AspNetCore.Mvc;
using webapp.Api.Dto.Subscription;
using webapp.Api.Service.Subscription;

namespace webapp.Api.Controller;

[ApiController]
[Route("api/v1/subscriptions")]
public class SubscriptionController(ISubscriptionService subscriptionService) : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllPlatforms()
    {
        return Ok(subscriptionService.GetAllSubscriptions());
    }

    [HttpGet("{id:int}")]
    public IActionResult GetSubscription([FromRoute] int id)
    {
        return Ok(subscriptionService.GetSubscription(id));
    }

    [HttpPost]
    public IActionResult CreateSubscription([FromBody] CreateSubscriptionDto createSubscriptionDto)
    {
        return Ok(subscriptionService.CreateSubscription(createSubscriptionDto));
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateSubscription([FromRoute] int id, [FromBody] UpdateSubscriptionDto updateSubscriptionDto)
    {
        return Ok(subscriptionService.UpdateSubscription(id, updateSubscriptionDto));
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteSubscription([FromRoute] int id)
    {
        subscriptionService.DeleteSubscription(id);
        return NoContent();
    }
}
