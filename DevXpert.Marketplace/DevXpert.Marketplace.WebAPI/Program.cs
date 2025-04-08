using DevXpert.Marketplace.Application;
using DevXpert.Marketplace.Infrastructure;
using DevXpert.Marketplace.WebAPI;
using DevXpert.Marketplace.WebAPI.Middleware;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddCors(
    x => x.AddPolicy(
        Configuration.CorsPolicyName,
        policy => policy
            .WithOrigins([
                Configuration.BackEndURL,
                Configuration.FrontEndURL
            ])
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials()
    ));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .AddPresentation()
    .AddApplication()
    .AddPersistence(configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();
app.MapEndpoints();
app.UseMiddleware<ExceptionHandlingMiddleware>();
app.UseHttpsRedirection();
app.UseSwaggerSetup();

app.Run();