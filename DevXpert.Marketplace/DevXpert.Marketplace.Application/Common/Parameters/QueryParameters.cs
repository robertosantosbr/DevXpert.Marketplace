using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevXpert.Marketplace.Application.Common;

public class QueryParameters : PaginationParameters
{
    public virtual string? SortColumn { get; set; }

    public virtual string? SortOrder { get; set; }
}