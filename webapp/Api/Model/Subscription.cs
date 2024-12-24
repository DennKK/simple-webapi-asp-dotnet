using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapp.Api.Model;

public class Subscription
{
    public int Id { get; set; }
    public int PlatformId { get; set; }
    [MaxLength(32)] public string Name { get; set; } = string.Empty;
    [Column(TypeName = "decimal(18,2")] public decimal Price { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool Status { get; set; }

    public required Platform Platform { get; set; }
}
