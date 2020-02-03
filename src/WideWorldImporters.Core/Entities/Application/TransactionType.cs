using System;
using System.Collections.Generic;
using WideWorldImporters.Core.Entities.Puchasing;
using WideWorldImporters.Core.Entities.Sales;
using WideWorldImporters.Core.Entities.Warehouse;

namespace WideWorldImporters.Core.Entities.Application
{
    public partial class TransactionType
    {
        public TransactionType()
        {
            CustomerTransactions = new HashSet<CustomerTransaction>();
            StockItemTransactions = new HashSet<StockItemTransaction>();
            SupplierTransactions = new HashSet<SupplierTransaction>();
        }

        public int TransactionTypeId { get; set; }
        public string TransactionTypeName { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public virtual Person LastEditedByNavigation { get; set; }
        public virtual ICollection<CustomerTransaction> CustomerTransactions { get; set; }
        public virtual ICollection<StockItemTransaction> StockItemTransactions { get; set; }
        public virtual ICollection<SupplierTransaction> SupplierTransactions { get; set; }
    }
}