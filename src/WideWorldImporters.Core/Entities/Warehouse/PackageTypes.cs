using System;
using System.Collections.Generic;
using WideWorldImporters.Core.Entities.Application;
using WideWorldImporters.Core.Entities.Puchasing;
using WideWorldImporters.Core.Entities.Sales;

namespace WideWorldImporters.Core.Entities.Warehouse
{
    public partial class PackageTypes
    {
        public PackageTypes()
        {
            InvoiceLines = new HashSet<InvoiceLines>();
            OrderLines = new HashSet<OrderLines>();
            PurchaseOrderLines = new HashSet<PurchaseOrderLines>();
            StockItemsOuterPackage = new HashSet<StockItems>();
            StockItemsUnitPackage = new HashSet<StockItems>();
        }

        public int PackageTypeId { get; set; }
        public string PackageTypeName { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public virtual People LastEditedByNavigation { get; set; }
        public virtual ICollection<InvoiceLines> InvoiceLines { get; set; }
        public virtual ICollection<OrderLines> OrderLines { get; set; }
        public virtual ICollection<PurchaseOrderLines> PurchaseOrderLines { get; set; }
        public virtual ICollection<StockItems> StockItemsOuterPackage { get; set; }
        public virtual ICollection<StockItems> StockItemsUnitPackage { get; set; }
    }
}