using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace DevXpert.Marketplace.Domain.Responses;

public class PagedResponse<T> : Response<T>
{
    public int CurrentPage { get; set; }

    public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);

    public int PageSize { get; set; } = Configuration.DefaultPageSize;

    public int TotalCount { get; set; }

    public bool HasPrevious => CurrentPage > 1;

    public bool HasNext => CurrentPage < TotalPages;

    [JsonConstructor]
    public PagedResponse(
        T? data,
        int totalCount,
        int currentPage = 1,
        int pageSize = Configuration.DefaultPageSize) : base(data)
    {
        Data = data;
        TotalCount = totalCount;
        CurrentPage = currentPage;
        PageSize = pageSize;
    }

    public PagedResponse(
        T? data,
        int statusCode = Configuration.DefaultStatusCode,
        string? message = null)
        : base(data, statusCode, message) { }

}
