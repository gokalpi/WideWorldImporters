using System;
using System.Collections.Generic;
using WideWorldImporters.Core.Entities.Application;
using WideWorldImporters.Core.Entities.Sales;

namespace WideWorldImporters.Core.Entities.Warehouse
{
    public partial class StockGroup : Entity
    {
        public StockGroup()
        {
            SpecialDeals = new HashSet<SpecialDeal>();
            StockItemStockGroups = new HashSet<StockItemStockGroup>();
        }

        public string StockGroupName { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public virtual Person LastEditedByNavigation { get; set; }
        public virtual ICollection<SpecialDeal> SpecialDeals { get; set; }
        public virtual ICollection<StockItemStockGroup> StockItemStockGroups { get; set; }
    }
}