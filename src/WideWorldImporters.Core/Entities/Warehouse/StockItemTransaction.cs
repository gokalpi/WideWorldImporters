using System;
using WideWorldImporters.Core.Entities.Application;
using WideWorldImporters.Core.Entities.Puchasing;
using WideWorldImporters.Core.Entities.Sales;

namespace WideWorldImporters.Core.Entities.Warehouse
{
    public partial class StockItemTransaction : Entity
    {
        public int StockItemId { get; set; }
        public int TransactionTypeId { get; set; }
        public int? CustomerId { get; set; }
        public int? InvoiceId { get; set; }
        public int? SupplierId { get; set; }
        public int? PurchaseOrderId { get; set; }
        public DateTime TransactionOccurredWhen { get; set; }
        public decimal Quantity { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime LastEditedWhen { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual Person LastEditedByNavigation { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual StockItem StockItem { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual TransactionType TransactionType { get; set; }
    }
}