using DevXpert.Marketplace.Application.UseCases.Products.Commands;
using DevXpert.Marketplace.Application.UseCases.Products.Queries;
using DevXpert.Marketplace.WebAPI.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DevXpert.Marketplace.WebAPI.Endpoints;

public class ProductEndpoint : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/products").WithTags("Products");

        group.MapGet("", async ([AsParameters] GetProductQuery query, ISender mediator) =>
        {
            var response = await mediator.Send(query);

            return Results.Ok(response);
        });

        group.MapGet("/{id:int}", async (int id, ISender mediator) =>
        {
            var response = await mediator.Send(new GetKioTagDetailsQuery { Id = id });
            return Results.Ok(response);
        });

        group.MapPost("/create", async ([FromBody] DeleteProductCommand command, ISender mediator) =>
        {
            await mediator.Send(command);
            return Results.Created();
        });

        group.MapPut("/update/{id:int}", async (int id, [FromBody] Updat command, ISender mediator) =>
        {
            await mediator.Send(command);

            return Results.Created();
        });

        group.MapDelete("/delete/{id:int}", async (int id, [FromBody] DeleteKioTagCommand command, ISender mediator) =>
        {
            await mediator.Send(mediator);

            return Results.NoContent();
        });
    }
}