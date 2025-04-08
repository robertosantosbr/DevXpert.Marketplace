using DevXpert.Marketplace.Application.UseCases.Products.Queries;
using DevXpert.Marketplace.Domain.Entities;
using DevXpert.Marketplace.Domain.Interfaces;
using DevXpert.Marketplace.Domain.Responses;

namespace DevXpert.Marketplace.Application.Contracts.Interfaces;

public interface IProductRepository : IBaseRepository<Products>
{
    Task<PagedResponse<List<Products>>> FindAllPagedListAsync(GetProductQuery request, CancellationToken cancellationToken);
}
