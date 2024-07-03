using Asparagus.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Asparagus.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration["SQLiteConnection"];

        services.AddDbContext<AsparagusDbContext>(options =>
        {
            options.UseSqlite(connectionString);
        });

        services.AddScoped<IAsparagusDbContext>(provider =>
            provider.GetService<AsparagusDbContext>());

        return services;
    }
}