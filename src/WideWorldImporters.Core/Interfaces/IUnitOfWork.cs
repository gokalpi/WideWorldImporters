using System;
using System.Threading;
using System.Threading.Tasks;

namespace WideWorldImporters.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> Repository<T>() where T : class, IEntity;
        IRepository<T, TKey> Repository<T, TKey>() where T : class, IEntity<TKey>;

        int SaveChanges();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}