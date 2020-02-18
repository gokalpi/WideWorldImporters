using System;
using WideWorldImporters.Core.Interfaces;

namespace WideWorldImporters.Application.Interfaces
{
    public interface IService
    {
        IUnitOfWork UnitOfWork { get; }
    }
}