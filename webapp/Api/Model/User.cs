using System.ComponentModel.DataAnnotations;

namespace webapp.Api.Model;

public class User
{
    public int Id { get; set; }
    [MaxLength(32)] public string Username { get; set; } = string.Empty;
    [MaxLength(64)] public string Email { get; set; } = string.Empty;
    public DateTime CreatedAt { get; } = DateTime.UtcNow;
    public List<Subscription> Subscriptions { get; set; } = [];
}
