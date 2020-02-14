using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WideWorldImporters.Core.Interfaces;
using WideWorldImporters.Infrastructure.Data.Repositories;

namespace WideWorldImporters.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WideWorldImportersContext _context;
        private readonly IDictionary<Type, object> _repositories;

        public UnitOfWork(WideWorldImportersContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _repositories = new Dictionary<Type, object>();
        }

        public IRepository<T> Repository<T>() where T : class, IEntity
        {
            IRepository<T> repository;
            if (!_repositories.ContainsKey(typeof(T)))
                _repositories.Add(typeof(T), repository = new Repository<T>(_context));
            else
                repository = _repositories[typeof(T)] as Repository<T>;
            return repository;
        }

        public IRepository<T, TKey> Repository<T, TKey>() where T : class, IEntity<TKey>
        {
            IRepository<T, TKey> repository;
            if (!_repositories.ContainsKey(typeof(T)))
                _repositories.Add(typeof(T), repository = new Repository<T, TKey>(_context));
            else
                repository = _repositories[typeof(T)] as Repository<T, TKey>;
            return repository;
        }

        public virtual int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public virtual async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }

        #region IDisposable Support

        private bool disposed = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                disposed = true;
            }
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion IDisposable Support
    }
}