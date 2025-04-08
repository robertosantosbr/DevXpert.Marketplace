using DevXpert.Marketplace.Domain.Common;

namespace DevXpert.Marketplace.Domain.Common;

public class QueryResultResponse<TEntity> : PagedListResponse
{
    public IEnumerable<TEntity> Data { get; set; } = Enumerable.Empty<TEntity>();
}