using DevXpert.Marketplace.Application.UseCases.Products.Commands;
using DevXpert.Marketplace.Domain.Entities;
using DevXpert.Marketplace.Domain.Responses;

namespace DevXpert.Marketplace.Application.Common.Mapping;

public class ProductProfile
{
    public ProductProfile()
    {
        //CreateMap<Products, Products>().ReverseMap();
        CreateMap<Products, CreateProductCommand>().ReverseMap();
        CreateMap<Products, CreateProductResponse>().ReverseMap();
        CreateMap<Products, UpdateProductCommand>().ReverseMap();
    }
}
