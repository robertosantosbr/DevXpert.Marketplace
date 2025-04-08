using AutoMapper;
using DevXpert.Marketplace.Application.Contracts.Interfaces;
using DevXpert.Marketplace.Domain.Entities;
using DevXpert.Marketplace.Domain.Interfaces;
using DevXpert.Marketplace.Domain.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevXpert.Marketplace.Application.UseCases.Products.Commands;
namespace DevXpert.Marketplace.Domain;

public class CreateProductCommandHandler : IRequestHandler<DeleteProductCommand, CreateProductResponse>
{
    private readonly IProductRepository _productRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _productRepository = productRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<CreateProductResponse> Handle(DeleteProductCommand command, CancellationToken cancellationToken)
    {

        var product = _mapper.Map<Products>(command);

        await _productRepository.InsertAsync(product, cancellationToken);

        await _unitOfWork.CommitAsync(cancellationToken);

        return _mapper.Map<CreateProductResponse>(product);
    }
}
