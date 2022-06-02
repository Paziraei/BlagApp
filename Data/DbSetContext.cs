using Microsoft.EntityFrameworkCore;
namespace Data;

public class DbSetContext : DbContext   
{
    public DbSetContext()
    {
    }

    public DbSet<Models.User> Users { get; set; }
    public DbSet<Models.Category> Categories { get; set; }
    public DbSet<Models.Comment> Comments { get; set; }
    public DbSet<Models.Gallery> Galleries { get; set; }
    public DbSet<Models.Post> Posts { get; set; }
    public DbSet<Models.Role> Roles { get; set; }
    public DbSet<Models.UserRole> UserRoles { get; set; }
    public DbSet<Models.TypeWork> TypeWorks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer("Data Source=.;initial catalog=BlogDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        base.OnConfiguring(optionsBuilder);
    }
}
