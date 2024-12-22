﻿namespace webapp.api.Models;

public class Subscription
{
    public long Id { get; set; }
    public int UserId { get; set; }
    public int ServiceId { get; set; }
    public int SubscriptionPlanId { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool Status { get; set; }

    public required User User { get; set; }
    public required Service Service { get; set; }
    public required SubscriptionPlan SubscriptionPlan { get; set; }
}
