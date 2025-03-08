using Diiage.Memoire.Repositories;
using Diiage.Memoire.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Thinktecture;

namespace Diiage.Memoire.Back.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration appSettings)
    {
        services.ConfigureDbContext(appSettings["ConnectionStrings:Db"]);
        RegisterRepositories(services);

        return services;
    }

    private static void RegisterRepositories(IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork<DbContextCore>>();
    }

    private static void ConfigureDbContext(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<DbContextCore>(optionsBuilder =>
        {
            optionsBuilder.UseSqlServer(connectionString, sqlBuilder =>
            {
                sqlBuilder.MigrationsAssembly("Diiage.Memoire.Back.Persistence.Migrations");
                sqlBuilder.MigrationsHistoryTable("__EFMigrationsHistory");
                sqlBuilder.AddTableHintSupport();
            });
        });
    }
}