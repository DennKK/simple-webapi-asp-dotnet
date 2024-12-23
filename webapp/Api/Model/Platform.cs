using System.ComponentModel.DataAnnotations;

namespace webapp.Api.Model;

public class Platform
{
    public int Id { get; set; }
    [MaxLength(100)] public string Name { get; set; } = string.Empty;
    public string Description = string.Empty;
    public List<SubscriptionPlan> SubscriptionPlans { get; set; } = [];
}
