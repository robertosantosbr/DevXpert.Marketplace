using DevXpert.Marketplace.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevXpert.Marketplace.Domain.Responses;

public sealed class GetProductResponse
{
    public int IdProduct { get; set; }

    public Categories Category { get; set; } = new();

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public bool IsActive { get; set; }
}
