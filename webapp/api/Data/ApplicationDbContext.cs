using Microsoft.EntityFrameworkCore;
using webapp.api.Model;

namespace webapp.api.Data
{
    public class ApplicationDbContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions)
    {
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<SubscriptionPlan> SubscriptionPlans { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
