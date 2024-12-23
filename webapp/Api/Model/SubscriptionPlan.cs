using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapp.Api.Model;

public class SubscriptionPlan
{
    public int Id { get; set; }
    public int ServiceId { get; set; }
    [MaxLength(32)] public string Name { get; set; } = string.Empty;
    [Column(TypeName = "decimal(18,2")] public decimal Price { get; set; }
    [MaxLength(32)] public string Duration { get; set; } = string.Empty;
    [MaxLength(128)] public string Features { get; set; } = string.Empty;

    public required Platform Platform;
}
