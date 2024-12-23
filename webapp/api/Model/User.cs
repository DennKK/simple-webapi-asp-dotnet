namespace webapp.api.Model;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime CreatedAt { get; } = DateTime.UtcNow;
    public List<Subscription> Subscriptions { get; set; } = [];
}
