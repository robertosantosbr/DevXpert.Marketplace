using DevXpert.Marketplace.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevXpert.Marketplace.Application.UseCases.Products.Commands;

public class DeleteProductCommand
{
    public int IdProduct { get; set; }

    public int IdCategory { get; set; }

    public int IdSeller { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public int CreatedBy { get; set; }

    public bool IsActive { get; set; }
}
