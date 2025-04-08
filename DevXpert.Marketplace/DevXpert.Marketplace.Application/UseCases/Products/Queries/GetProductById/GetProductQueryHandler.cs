using AutoMapper;
using DevXpert.Marketplace.Application.Contracts.Interfaces;
using DevXpert.Marketplace.Domain.Exceptions;
using DevXpert.Marketplace.Domain.Responses;
using MediatR;

namespace DevXpert.Marketplace.Application.UseCases.Products.Queries;

public class GetProductQueryHandler : IRequestHandler<GetProductQuery, GetProductResponse>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public GetProductQueryHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<GetProductResponse> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        var product = await _productRepository.FindUniqueAsync(x => x.IdProduct == request.Id, cancellationToken);

        if (product is null)
            throw new NotFoundException(nameof(product), request.Id);

        return _mapper.Map<GetProductResponse>(product);
    }
}
