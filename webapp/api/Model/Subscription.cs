using System.ComponentModel.DataAnnotations;

namespace webapp.api.Model;

public class Subscription
{
    public long Id { get; set; }
    public int UserId { get; set; }
    public int ServiceId { get; set; }
    public int SubscriptionPlanId { get; set; }
    [MaxLength(100)] public string Name { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool Status { get; set; }

    public required User User { get; set; }
    public required Platform Platform { get; set; }
    public required SubscriptionPlan SubscriptionPlan { get; set; }
}
