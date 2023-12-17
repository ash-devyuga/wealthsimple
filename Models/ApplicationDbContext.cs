using Microsoft.EntityFrameworkCore;

// Move using directive to the top of the file
public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Use the Docker Compose service name as the host
        optionsBuilder.UseNpgsql("Host=postgres;Database=wealthsimple;Username=wealthsimple;Password=my_password");
    }
}
