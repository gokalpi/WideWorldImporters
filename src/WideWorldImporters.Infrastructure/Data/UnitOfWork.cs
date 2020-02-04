using System;
using System.Threading;
using System.Threading.Tasks;
using WideWorldImporters.Core.Interfaces;

namespace WideWorldImporters.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WideWorldImportersContext _context;

        public UnitOfWork(WideWorldImportersContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public virtual int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public virtual async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}