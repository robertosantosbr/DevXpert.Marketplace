using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevXpert.Marketplace.Domain.Interfaces;

public interface IBaseRepository<TEntity>
{
    Task InsertAsync(TEntity entity, CancellationToken cancellationToken);

    Task InsertRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken);

    void Update(TEntity entity);

    void UpdateRange(IEnumerable<TEntity> entities);

    void Remove(TEntity entity);

    void RemoveRange(IEnumerable<TEntity> entities);

    Task<List<TEntity>> FindAllAsync(CancellationToken cancellationToken);

    Task<List<TEntity>> FindByAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);

    Task<TEntity?> FindUniqueAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);

    Task<bool> ExistAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);
}