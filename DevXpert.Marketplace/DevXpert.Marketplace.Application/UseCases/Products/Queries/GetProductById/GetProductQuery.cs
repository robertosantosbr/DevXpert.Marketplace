using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevXpert.Marketplace.Domain.Responses;
using MediatR;

namespace DevXpert.Marketplace.Application.UseCases.Products.Queries;

public class GetProductQuery : IRequest<GetProductResponse>
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }
}
