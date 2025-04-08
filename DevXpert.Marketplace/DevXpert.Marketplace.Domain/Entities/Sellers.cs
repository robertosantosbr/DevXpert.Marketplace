using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevXpert.Marketplace.Domain.Entities;

public partial class Sellers
{
    public int IdSeller { get; set; }

    public SellersType SellerType { get; set; } = new();

    public string FullName { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public int CreatedBy { get; set; }

    public bool IsActive { get; set; }
}