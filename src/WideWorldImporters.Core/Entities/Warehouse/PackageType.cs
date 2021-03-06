﻿using System;
using System.Collections.Generic;
using WideWorldImporters.Core.Entities.Application;
using WideWorldImporters.Core.Entities.Puchasing;
using WideWorldImporters.Core.Entities.Sales;
using WideWorldImporters.Core.Interfaces;

namespace WideWorldImporters.Core.Entities.Warehouse
{
    public class PackageType : IAuditableEntity
    {
        public PackageType()
        {
            InvoiceLines = new HashSet<InvoiceLine>();
            OrderLines = new HashSet<OrderLine>();
            PurchaseOrderLines = new HashSet<PurchaseOrderLine>();
            StockItemsOuterPackage = new HashSet<StockItem>();
            StockItemsUnitPackage = new HashSet<StockItem>();
        }

        public int Id { get; set; }
        public string PackageTypeName { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public virtual Person LastEditedByNavigation { get; set; }
        public virtual ICollection<InvoiceLine> InvoiceLines { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
        public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; }
        public virtual ICollection<StockItem> StockItemsOuterPackage { get; set; }
        public virtual ICollection<StockItem> StockItemsUnitPackage { get; set; }
    }
}