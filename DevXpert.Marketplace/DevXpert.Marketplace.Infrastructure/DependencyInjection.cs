using DevXpert.Marketplace.Application.Contracts.Interfaces;
using DevXpert.Marketplace.Domain.Interfaces;
using DevXpert.Marketplace.Infrastructure.Context;
using DevXpert.Marketplace.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DevXpert.Marketplace.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        string connectionString = configuration.GetConnectionString(ConnectionString.SettingsKey)!;

        services.AddSingleton(new ConnectionString(connectionString));

        services.AddDbContext<MarketplaceDbContext>(options => options.UseSqlServer(connectionString));

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services = RegisterRepositories(services);

        return services;
    }

    private static IServiceCollection RegisterRepositories(this IServiceCollection services)
    {
        services.AddScoped<IProductRepository, ProductRepository>();

        return services;
    }
}
