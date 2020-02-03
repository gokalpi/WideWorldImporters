namespace WideWorldImporters.Core.Interfaces
{
    public interface IEntity : IEntity<int>
    {
    }

    public interface IEntity<TId>
    {
        TId Id { get; }
    }
}