using Microsoft.EntityFrameworkCore;

namespace Diiage.Memoire.Back.Persistence;

public class DbContextCore : DbContext
{
    public DbContextCore()
    {
    }

    public DbContextCore(DbContextOptions<DbContextCore> dbContextOptions)
        : base(dbContextOptions)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.HasDefaultSchema("diiage-memoire-core");

        builder.ApplyConfigurationsFromAssembly(typeof(DbContextCore).Assembly);
    }
}