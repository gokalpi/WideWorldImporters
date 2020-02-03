using System;
using System.Collections.Generic;
using WideWorldImporters.Core.Entities.Application;

namespace WideWorldImporters.Core.Entities.Sales
{
    public partial class BuyingGroup : Entity
    {
        public BuyingGroup()
        {
            Customers = new HashSet<Customer>();
            SpecialDeals = new HashSet<SpecialDeal>();
        }

        public string BuyingGroupName { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public virtual Person LastEditedByNavigation { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<SpecialDeal> SpecialDeals { get; set; }
    }
}