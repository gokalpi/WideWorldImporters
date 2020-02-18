namespace WideWorldImporters.Core.Interfaces
{
    public interface IAuditableEntity : IEntity
    {
        public int? LastEditedBy { get; set; }
    }
}