using System.ComponentModel.DataAnnotations;

namespace webapp.Api.Model;

public class Platform
{
    public int Id { get; set; }
    [MaxLength(32)] public string Name { get; set; } = string.Empty;
    [MaxLength(512)] public string Description { get; set; } = string.Empty;
    public List<SubscriptionPlan> SubscriptionPlans { get; set; } = [];
}
