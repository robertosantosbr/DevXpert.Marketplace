namespace DevXpert.Marketplace.Domain.Common;

public class QueryResult<TEntity> : PagedListResponse
{
    public IEnumerable<TEntity> Data { get; set; } = Enumerable.Empty<TEntity>();
}
