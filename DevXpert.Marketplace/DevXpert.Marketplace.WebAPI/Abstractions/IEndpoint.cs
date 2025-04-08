namespace DevXpert.Marketplace.WebAPI.Abstractions;

public interface IEndpoint
{
    void MapEndpoint(IEndpointRouteBuilder app);
}