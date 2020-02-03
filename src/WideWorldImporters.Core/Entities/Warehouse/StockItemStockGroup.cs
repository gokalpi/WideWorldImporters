﻿using System;
using WideWorldImporters.Core.Entities.Application;

namespace WideWorldImporters.Core.Entities.Warehouse
{
    public partial class StockItemStockGroup : Entity
    {
        public int StockItemId { get; set; }
        public int StockGroupId { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime LastEditedWhen { get; set; }

        public virtual Person LastEditedByNavigation { get; set; }
        public virtual StockGroup StockGroup { get; set; }
        public virtual StockItem StockItem { get; set; }
    }
}