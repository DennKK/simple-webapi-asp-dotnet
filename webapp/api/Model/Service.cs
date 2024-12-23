namespace webapp.api.Model;

public class Service
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description = string.Empty;
    public List<SubscriptionPlan> SubscriptionPlans { get; set; } = [];
}
