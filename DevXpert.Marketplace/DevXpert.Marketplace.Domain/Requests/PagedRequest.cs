using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevXpert.Marketplace.Domain.Requests;

public abstract class PagedRequest : Request
{
    public int PageNumber { get; set; } = Configuration.DefaultPageNumber;

    public int PageSize { get; set; } = Configuration.DefaultPageSize;

    public string? SortColumn { get; set; }

    public bool? SortOrder { get; set; }
}
