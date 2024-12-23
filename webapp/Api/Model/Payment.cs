using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapp.Api.Model;

public class Payment
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int SubscriptionId { get; set; }
    [Column(TypeName = "decimal(18,2)")] public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    [MaxLength(64)] public string PaymentMethod { get; set; } = string.Empty;

    public required User User { get; set; }
    public required Subscription Subscription { get; set; }
}
