using System.ComponentModel.DataAnnotations.Schema;

namespace webapp.api.Models;

public class SubscriptionPlan
{
    public int Id { get; set; }
    public int ServiceId { get; set; }
    public string Name { get; set; } = string.Empty;
    [Column(TypeName = "decimal(18,2")] public decimal Price { get; set; }
    public string Duration { get; set; } = string.Empty;
    public string Features { get; set; } = string.Empty;

    public required Service Service;
}
