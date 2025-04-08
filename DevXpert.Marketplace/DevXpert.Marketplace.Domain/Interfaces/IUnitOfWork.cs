using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevXpert.Marketplace.Domain.Interfaces;

public interface IUnitOfWork: IDisposable
{
    Task CommitAsync(bool commitTransaction = true);

    Task CommitAsync(CancellationToken cancellationToken, bool commitTransaction = true);

    Task RollbackAsync();
}