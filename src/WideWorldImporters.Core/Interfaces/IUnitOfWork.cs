using System.Threading;
using System.Threading.Tasks;

namespace WideWorldImporters.Core.Interfaces
{
    public interface IUnitOfWork
    {
        int SaveChanges();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}