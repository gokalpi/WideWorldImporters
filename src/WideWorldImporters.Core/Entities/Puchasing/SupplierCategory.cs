﻿using System;
using System.Collections.Generic;
using WideWorldImporters.Core.Entities.Application;

namespace WideWorldImporters.Core.Entities.Puchasing
{
    public partial class SupplierCategory : Entity
    {
        public SupplierCategory()
        {
            Suppliers = new HashSet<Supplier>();
        }

        public string SupplierCategoryName { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public virtual Person LastEditedByNavigation { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}