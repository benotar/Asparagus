using Asparagus.Application.Interfaces;
using Asparagus.Domain.Entities;
using Asparagus.Persistence.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;

namespace Asparagus.Persistence;

public class AsparagusDbContext : DbContext, IAsparagusDbContext
{
    public DbSet<User> Users { get; set; }

    public DbSet<UserEating> UsersEatings { get; set; }

    public AsparagusDbContext(DbContextOptions<AsparagusDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AsparagusUserConfiguration());
        modelBuilder.ApplyConfiguration(new AsparagusUserEatingConfiguration());

        
        base.OnModelCreating(modelBuilder);
    }
}