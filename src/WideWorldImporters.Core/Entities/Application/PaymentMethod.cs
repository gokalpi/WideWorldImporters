using System;
using System.Collections.Generic;
using WideWorldImporters.Core.Entities.Puchasing;
using WideWorldImporters.Core.Entities.Sales;

namespace WideWorldImporters.Core.Entities.Application
{
    public partial class PaymentMethod : Entity
    {
        public PaymentMethod()
        {
            CustomerTransactions = new HashSet<CustomerTransaction>();
            SupplierTransactions = new HashSet<SupplierTransaction>();
        }

        public string PaymentMethodName { get; set; }
        public int? LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public virtual Person LastEditedByNavigation { get; set; }
        public virtual ICollection<CustomerTransaction> CustomerTransactions { get; set; }
        public virtual ICollection<SupplierTransaction> SupplierTransactions { get; set; }
    }
}