using System;
using WideWorldImporters.Core.Entities.Application;
using WideWorldImporters.Core.Entities.Warehouse;
using WideWorldImporters.Core.Interfaces;

namespace WideWorldImporters.Core.Entities.Puchasing
{
    public class PurchaseOrderLine : IAuditableEntity
    {
        public int Id { get; set; }
        public int PurchaseOrderId { get; set; }
        public int StockItemId { get; set; }
        public int OrderedOuters { get; set; }
        public string Description { get; set; }
        public int ReceivedOuters { get; set; }
        public int PackageTypeId { get; set; }
        public decimal? ExpectedUnitPricePerOuter { get; set; }
        public DateTime? LastReceiptDate { get; set; }
        public bool IsOrderLineFinalized { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime LastEditedWhen { get; set; }

        public virtual Person LastEditedByNavigation { get; set; }
        public virtual PackageType PackageType { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual StockItem StockItem { get; set; }
    }
}