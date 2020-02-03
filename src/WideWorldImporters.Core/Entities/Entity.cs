using WideWorldImporters.Core.Interfaces;

namespace WideWorldImporters.Core.Entities
{
    public abstract class Entity : Entity<int>
    {
    }

    public abstract class Entity<TId> : IEntity<TId>
    {
        public virtual TId Id { get; set; }
    }
}