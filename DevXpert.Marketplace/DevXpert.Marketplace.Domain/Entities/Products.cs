using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevXpert.Marketplace.Domain.Entities;

public partial class Products
{
    public int IdProduct { get; set; }

    public Categories Category { get; set; } = new();

    public Sellers Seller { get; set; } = new();

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public int CreatedBy { get; set; }

    public bool IsActive { get; set; }
}