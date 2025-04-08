using AutoMapper;
using DevXpert.Marketplace.Application.Contracts.Interfaces;
using DevXpert.Marketplace.Application.UseCases.Categories.Queries;
using DevXpert.Marketplace.Domain.Entities;
using DevXpert.Marketplace.Domain.Responses;
using DevXpert.Marketplace.Infrastructure.Context;
using DevXpert.Marketplace.Infrastructure.Extensions;
using System.Linq.Expressions;

namespace DevXpert.Marketplace.Infrastructure.Repositories;

public class ProductRepository : BaseRpository<Products>, IProductRepository
{
    private readonly MarketplaceDbContext _dbContext;
    private readonly IMapper _mapper;

    public ProductRepository(MarketplaceDbContext _dbContext, IMapper mapper) : base(_dbContext)
    {
        this._dbContext = _dbContext;
        _mapper = mapper;
    }

    public async Task<PagedResponse<List<Products>>> FindAllPagedListAsync(GetProductQuery request, CancellationToken cancellationToken)
    {
        IQueryable<Products> productsQuery = _dbSet;

        Expression<Func<Products, bool>> predicate = x =>
            (string.IsNullOrEmpty(request.Name) || x.Name.Contains(request.Name)) &&
            (string.IsNullOrEmpty(request.Description) || x.Description.Contains(request.Description));

        productsQuery = productsQuery.Where(predicate);

        productsQuery = request.SortOrder?.ToLower() == "desc"
            ? productsQuery.OrderByDescending(GetSortProperty(request))
            : productsQuery.OrderBy(GetSortProperty(request));

        var productsList = await productsQuery
            .PagedListAsync(request.PageNumber, request.PageSize);

        return new PagedResponse<List<Products>>(productsList, productsList.TotalCount, request.PageNumber, request.PageSize);
    }

    private static Expression<Func<Products, object>> GetSortProperty(GetProductQuery request) =>
        request.SortColumn?.ToLower() switch
        {
            "id" => products => products.IdProduct,
            "name" => products => products.Name,
            "description" => products => products.Description ?? string.Empty,
            "active" => products => products.IsActive,
            _ => products => products.IdProduct
        };
}
