using System.ComponentModel.DataAnnotations.Schema;

namespace webapp.api.Models;

public class Payment
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int SubscriptionId { get; set; }
    [Column(TypeName = "decimal(18,2)")] public decimal Amount { get; set; }
    public DateTime PaymentDate;
    public string PaymentMethod { get; set; } = string.Empty;
}
