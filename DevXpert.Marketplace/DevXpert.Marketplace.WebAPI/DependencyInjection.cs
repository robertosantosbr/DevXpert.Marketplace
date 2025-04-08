using DevXpert.Marketplace.WebAPI.Abstractions;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace DevXpert.Marketplace.WebAPI;


public static class Configuration
{
    public static string CorsPolicyName = "vusys";

    public static string FrontEndURL = "https://localhost:7044/";

    public static string BackEndURL = "https://localhost:7089/";
}

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();

        services.AddSwaggerConfiguration();

        services.AddTransient<ExceptionHandlingMiddleware>();

        services.AddEndpoints(assembly);

        return services;
    }

    public static void AddSwaggerConfiguration(this IServiceCollection services)
    {
        services.AddSwaggerGen(swagger =>
        {
            swagger.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "DevXpert Marketplace - Project",
                Description = "DevXpert Marketplace - API Swagger surface",
                Contact = new OpenApiContact
                {
                    Name = "Suporte",
                    Email = "suporte@desenvolvedor.io",
                    Url = new Uri("http://www.desenvolvedor.io/")
                },
                License = new OpenApiLicense
                {
                    Name = "MIT",
                    Url = new Uri("http://www.desenvolvedor.io/")
                }
            });

            swagger.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Description = "Input the JWT like: Bearer {your token}",
                Name = "Authorization",
                Scheme = "Bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.ApiKey
            });

            swagger.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[] {}
                }
            });
        });
    }

    public static void UseSwaggerSetup(this IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(config =>
        {
            config.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        });
    }

    public static IServiceCollection AddEndpoints(this IServiceCollection services, Assembly assembly)
    {
        ServiceDescriptor[] descriptors = assembly.DefinedTypes
            .Where(type => type is { IsAbstract: false, IsInterface: false })
            .Where(type => type.IsAssignableTo(typeof(IEndpoint)))
            .Select(type => ServiceDescriptor.Transient(typeof(IEndpoint), type))
            .ToArray();

        services.TryAddEnumerable(descriptors);

        return services;
    }

    public static IApplicationBuilder MapEndpoints(this WebApplication app, RouteGroupBuilder? routeGroupBuilder = null)
    {
        IEnumerable<IEndpoint> endpoints = app.Services.GetRequiredService<IEnumerable<IEndpoint>>();

        IEndpointRouteBuilder builder = routeGroupBuilder is null ? app : routeGroupBuilder;

        foreach (IEndpoint endpoint in endpoints)
        {
            endpoint.MapEndpoint(builder);
        }

        return app;
    }

}

