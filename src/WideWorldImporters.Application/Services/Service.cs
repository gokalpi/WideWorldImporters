using Microsoft.Extensions.Logging;
using WideWorldImporters.Application.Interfaces;
using WideWorldImporters.Core.Interfaces;

namespace WideWorldImporters.Application.Services
{
    public abstract class Service : IService
    {
        protected readonly ILogger Logger;

        public Service(ILogger logger, IUnitOfWork unitOfWork)
        {
            Logger = logger;
            UnitOfWork = unitOfWork;
        }

        public IUnitOfWork UnitOfWork { get; }
    }
}