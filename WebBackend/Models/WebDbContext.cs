using Microsoft.EntityFrameworkCore;

namespace WebBackend.Models;

public sealed class WebDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<News> News { get; set; }
    
    public WebDbContext(DbContextOptions contextOptions) : base(contextOptions)
    {
        Database.EnsureCreated();
    }
}