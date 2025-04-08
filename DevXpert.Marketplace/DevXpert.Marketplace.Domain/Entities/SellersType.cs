using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevXpert.Marketplace.Domain.Entities;
    
public partial class SellersType
{
    public int IdSellerType { get; set; }

    public string Name { get; set; } = string.Empty;
}