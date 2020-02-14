namespace WideWorldImporters.Core.Interfaces
{
    public interface IAuditableEntity
    {
        public int? LastEditedBy { get; set; }
    }
}