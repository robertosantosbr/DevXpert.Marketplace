using DevXpert.Marketplace.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DevXpert.Marketplace.Infrastructure.Repositories;

public class BaseRpository<TEntity> : IBaseRepository<TEntity> where TEntity : class
{
    protected DbSet<TEntity> _dbSet;

    public BaseRpository(DbContext dbContext)
        => _dbSet = dbContext.Set<TEntity>();

    public async Task InsertAsync(TEntity entity, CancellationToken cancellationToken)
        => await _dbSet.AddAsync(entity, cancellationToken);

    public async Task InsertRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken)
        => await _dbSet.AddRangeAsync(entities, cancellationToken);

    public void Update(TEntity entity)
        => _dbSet.Update(entity);

    public void UpdateRange(IEnumerable<TEntity> entities)
        => _dbSet.UpdateRange(entities);

    public void Remove(TEntity entity)
    => _dbSet.Remove(entity);

    public void RemoveRange(IEnumerable<TEntity> entities)
        => _dbSet.RemoveRange(entities);

    public Task<List<TEntity>> FindAllAsync(CancellationToken cancellationToken)
        => _dbSet.AsNoTracking().ToListAsync(cancellationToken);

    public Task<List<TEntity>> FindByAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken)
        => _dbSet.AsNoTracking().Where(predicate).ToListAsync();

    public Task<TEntity?> FindUniqueAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken)
        => _dbSet.FirstOrDefaultAsync(predicate, cancellationToken);

    public Task<bool> ExistAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken)
    => _dbSet.AnyAsync(predicate, cancellationToken);
}
