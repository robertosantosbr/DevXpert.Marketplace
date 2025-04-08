using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevXpert.Marketplace.Domain.Entities;

public partial class Categories
{
    public int IdCategory { get; set; }
        
    public string Name { get; set; } = string.Empty;
        
    public string Description { get; set; } = string.Empty;
        
    public int CreatedBy { get; set; }

    public bool IsActive { get; set; }
}