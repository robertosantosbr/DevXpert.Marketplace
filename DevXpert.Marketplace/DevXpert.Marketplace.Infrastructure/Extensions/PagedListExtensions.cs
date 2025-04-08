using DevXpert.Marketplace.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace DevXpert.Marketplace.Infrastructure.Extensions;

public static class PagedListExtensions
{
    public static async Task<PagedList<T>> PagedListAsync<T>(this IQueryable<T> source, int pageNumber, int pageSize)
    {
        var totalCount = await source.CountAsync();

        var items = await source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

        return new PagedList<T>(items, totalCount, pageNumber, pageSize);
    }
}
