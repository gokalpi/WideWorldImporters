using System;
using WideWorldImporters.Core.Entities.Application;
using WideWorldImporters.Core.Entities.Warehouse;
using WideWorldImporters.Core.Interfaces;

namespace WideWorldImporters.Core.Entities.Sales
{
    public partial class SpecialDeal : Entity, IAuditableEntity
    {
        public int? StockItemId { get; set; }
        public int? CustomerId { get; set; }
        public int? BuyingGroupId { get; set; }
        public int? CustomerCategoryId { get; set; }
        public int? StockGroupId { get; set; }
        public string DealDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime LastEditedWhen { get; set; }

        public virtual BuyingGroup BuyingGroup { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual CustomerCategory CustomerCategory { get; set; }
        public virtual Person LastEditedByNavigation { get; set; }
        public virtual StockGroup StockGroup { get; set; }
        public virtual StockItem StockItem { get; set; }
    }
}