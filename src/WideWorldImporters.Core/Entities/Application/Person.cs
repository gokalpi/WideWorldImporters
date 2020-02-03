using System;
using System.Collections.Generic;
using WideWorldImporters.Core.Entities.Puchasing;
using WideWorldImporters.Core.Entities.Sales;
using WideWorldImporters.Core.Entities.Warehouse;

namespace WideWorldImporters.Core.Entities.Application
{
    public partial class Person
    {
        public Person()
        {
            BuyingGroups = new HashSet<BuyingGroup>();
            Cities = new HashSet<City>();
            Colors = new HashSet<Color>();
            Countries = new HashSet<Country>();
            CustomerCategories = new HashSet<CustomerCategory>();
            CustomerTransactions = new HashSet<CustomerTransaction>();
            CustomersAlternateContactPerson = new HashSet<Customer>();
            CustomersLastEditedByNavigation = new HashSet<Customer>();
            CustomersPrimaryContactPerson = new HashSet<Customer>();
            DeliveryMethods = new HashSet<DeliveryMethod>();
            InverseLastEditedByNavigation = new HashSet<Person>();
            InvoiceLines = new HashSet<InvoiceLine>();
            InvoicesAccountsPerson = new HashSet<Invoice>();
            InvoicesContactPerson = new HashSet<Invoice>();
            InvoicesLastEditedByNavigation = new HashSet<Invoice>();
            InvoicesPackedByPerson = new HashSet<Invoice>();
            InvoicesSalespersonPerson = new HashSet<Invoice>();
            OrderLines = new HashSet<OrderLine>();
            OrdersContactPerson = new HashSet<Order>();
            OrdersLastEditedByNavigation = new HashSet<Order>();
            OrdersPickedByPerson = new HashSet<Order>();
            OrdersSalespersonPerson = new HashSet<Order>();
            PackageTypes = new HashSet<PackageType>();
            PaymentMethods = new HashSet<PaymentMethod>();
            PurchaseOrderLines = new HashSet<PurchaseOrderLine>();
            PurchaseOrdersContactPerson = new HashSet<PurchaseOrder>();
            PurchaseOrdersLastEditedByNavigation = new HashSet<PurchaseOrder>();
            SpecialDeals = new HashSet<SpecialDeal>();
            StateProvinces = new HashSet<StateProvince>();
            StockGroups = new HashSet<StockGroup>();
            StockItemHoldings = new HashSet<StockItemHolding>();
            StockItemStockGroups = new HashSet<StockItemStockGroup>();
            StockItemTransactions = new HashSet<StockItemTransaction>();
            StockItems = new HashSet<StockItem>();
            SupplierCategories = new HashSet<SupplierCategory>();
            SupplierTransactions = new HashSet<SupplierTransaction>();
            SuppliersAlternateContactPerson = new HashSet<Supplier>();
            SuppliersLastEditedByNavigation = new HashSet<Supplier>();
            SuppliersPrimaryContactPerson = new HashSet<Supplier>();
            SystemParameters = new HashSet<SystemParameter>();
            TransactionTypes = new HashSet<TransactionType>();
        }

        public int PersonId { get; set; }
        public string FullName { get; set; }
        public string PreferredName { get; set; }
        public string SearchName { get; set; }
        public bool IsPermittedToLogon { get; set; }
        public string LogonName { get; set; }
        public bool IsExternalLogonProvider { get; set; }
        public byte[] HashedPassword { get; set; }
        public bool IsSystemUser { get; set; }
        public bool IsEmployee { get; set; }
        public bool IsSalesperson { get; set; }
        public string UserPreferences { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string EmailAddress { get; set; }
        public byte[] Photo { get; set; }
        public string CustomFields { get; set; }
        public string OtherLanguages { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public virtual Person LastEditedByNavigation { get; set; }
        public virtual ICollection<BuyingGroup> BuyingGroups { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<Color> Colors { get; set; }
        public virtual ICollection<Country> Countries { get; set; }
        public virtual ICollection<CustomerCategory> CustomerCategories { get; set; }
        public virtual ICollection<CustomerTransaction> CustomerTransactions { get; set; }
        public virtual ICollection<Customer> CustomersAlternateContactPerson { get; set; }
        public virtual ICollection<Customer> CustomersLastEditedByNavigation { get; set; }
        public virtual ICollection<Customer> CustomersPrimaryContactPerson { get; set; }
        public virtual ICollection<DeliveryMethod> DeliveryMethods { get; set; }
        public virtual ICollection<Person> InverseLastEditedByNavigation { get; set; }
        public virtual ICollection<InvoiceLine> InvoiceLines { get; set; }
        public virtual ICollection<Invoice> InvoicesAccountsPerson { get; set; }
        public virtual ICollection<Invoice> InvoicesContactPerson { get; set; }
        public virtual ICollection<Invoice> InvoicesLastEditedByNavigation { get; set; }
        public virtual ICollection<Invoice> InvoicesPackedByPerson { get; set; }
        public virtual ICollection<Invoice> InvoicesSalespersonPerson { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
        public virtual ICollection<Order> OrdersContactPerson { get; set; }
        public virtual ICollection<Order> OrdersLastEditedByNavigation { get; set; }
        public virtual ICollection<Order> OrdersPickedByPerson { get; set; }
        public virtual ICollection<Order> OrdersSalespersonPerson { get; set; }
        public virtual ICollection<PackageType> PackageTypes { get; set; }
        public virtual ICollection<PaymentMethod> PaymentMethods { get; set; }
        public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrdersContactPerson { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrdersLastEditedByNavigation { get; set; }
        public virtual ICollection<SpecialDeal> SpecialDeals { get; set; }
        public virtual ICollection<StateProvince> StateProvinces { get; set; }
        public virtual ICollection<StockGroup> StockGroups { get; set; }
        public virtual ICollection<StockItemHolding> StockItemHoldings { get; set; }
        public virtual ICollection<StockItemStockGroup> StockItemStockGroups { get; set; }
        public virtual ICollection<StockItemTransaction> StockItemTransactions { get; set; }
        public virtual ICollection<StockItem> StockItems { get; set; }
        public virtual ICollection<SupplierCategory> SupplierCategories { get; set; }
        public virtual ICollection<SupplierTransaction> SupplierTransactions { get; set; }
        public virtual ICollection<Supplier> SuppliersAlternateContactPerson { get; set; }
        public virtual ICollection<Supplier> SuppliersLastEditedByNavigation { get; set; }
        public virtual ICollection<Supplier> SuppliersPrimaryContactPerson { get; set; }
        public virtual ICollection<SystemParameter> SystemParameters { get; set; }
        public virtual ICollection<TransactionType> TransactionTypes { get; set; }
    }
}