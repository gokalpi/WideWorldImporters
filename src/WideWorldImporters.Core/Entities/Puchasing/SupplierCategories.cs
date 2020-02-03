using System;
using System.Collections.Generic;
using WideWorldImporters.Core.Entities.Application;

namespace WideWorldImporters.Core.Entities.Puchasing
{
    public partial class SupplierCategories
    {
        public SupplierCategories()
        {
            Suppliers = new HashSet<Suppliers>();
        }

        public int SupplierCategoryId { get; set; }
        public string SupplierCategoryName { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public virtual People LastEditedByNavigation { get; set; }
        public virtual ICollection<Suppliers> Suppliers { get; set; }
    }
}