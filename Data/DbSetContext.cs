using Microsoft.EntityFrameworkCore;
namespace Data;

public class DbSetContext : DbContext
{
	public DbSetContext()
	{
	}

	#region All DbSet
	public DbSet<Models.User> Users { get; set; }
	public DbSet<Models.Category> Categories { get; set; }
	public DbSet<Models.Comment> Comments { get; set; }
	public DbSet<Models.Gallery> Galleries { get; set; }
	public DbSet<Models.Post> Posts { get; set; }
	public DbSet<Models.Role> Roles { get; set; }
	public DbSet<Models.UserRole> UserRoles { get; set; }
	public DbSet<Models.TypeWork> TypeWorks { get; set; }
	#endregion

	#region OnConfiguring
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder
			.UseSqlServer("Data Source=.;initial catalog=BlogDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
		base.OnConfiguring(optionsBuilder);
	}
	#endregion

	protected override void OnModelCreating(ModelBuilder builder)
	{
		// settings relations

		//post -> category
		builder.Entity<Models.Post>()

			.HasOne(current => current.Category)

			.WithMany(current => current.Posts)

			.HasForeignKey(current => current.CategoryId)

			.OnDelete(DeleteBehavior.SetNull);

		//builder.Entity<Models.Category>()
		//	.HasMany(current => current.Posts)
		//	.WithOne(current => current.Category)
		//	.HasForeignKey(current => current.CategoryId)
		//	.OnDelete(DeleteBehavior.SetNull);

		//user role -> role
		builder.Entity<Models.Role>()

			.HasMany(current => current.UserRoles)

			.WithOne(current => current.Role)

			.HasForeignKey(current => current.RoleId)

			.OnDelete(DeleteBehavior.NoAction);

		//user role -> user
		builder.Entity<Models.User>()

			.HasMany(current => current.UserRoles)

			.WithOne(current => current.User)

			.HasForeignKey(current => current.UserId)

			.OnDelete(DeleteBehavior.NoAction);

		// type work -> user
		builder.Entity<Models.User>()

			.HasMany(current => current.TypeWorks)

			.WithOne(current => current.User)

			.HasForeignKey(current => current.UserId)

			.OnDelete(DeleteBehavior.Cascade);

		// type work -> post
		builder.Entity<Models.Post>()

			.HasMany(current => current.TypeWorks)

			.WithOne(current => current.Post)

			.HasForeignKey(current => current.PostId)

			.OnDelete(DeleteBehavior.Cascade);

		//comment -> user
		builder.Entity<Models.Comment>()

			.HasOne(current => current.User)

			.WithMany(current => current.Comments)

			.HasForeignKey(current => current.UserId)

			.OnDelete(DeleteBehavior.Cascade);

		//comment -> post
		builder.Entity<Models.Comment>()

			.HasOne(current => current.Post)

			.WithMany(current => current.Comments)

			.HasForeignKey(current => current.PostId)

			.OnDelete(DeleteBehavior.Cascade);

		//gallery -> post
		builder.Entity<Models.Post>()

			.HasMany(current => current.Galleries)

			.WithOne(current => current.Post)

			.HasForeignKey(current => current.PostId)

			.OnDelete(DeleteBehavior.Cascade);

		//post -> user
		builder.Entity<Models.Post>()

			.HasOne(current => current.User)

			.WithMany(current => current.Posts)

			.HasForeignKey(current => current.UserId)

			.OnDelete(DeleteBehavior.SetNull);

		base.OnModelCreating(builder);
	}
}
