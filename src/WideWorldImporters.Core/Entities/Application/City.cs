using System;
using System.Collections.Generic;
using WideWorldImporters.Core.Entities.Puchasing;
using WideWorldImporters.Core.Entities.Sales;
using WideWorldImporters.Core.Interfaces;

namespace WideWorldImporters.Core.Entities.Application
{
    public partial class City : Entity, IAuditableEntity
    {
        public City()
        {
            CustomersDeliveryCity = new HashSet<Customer>();
            CustomersPostalCity = new HashSet<Customer>();
            SuppliersDeliveryCity = new HashSet<Supplier>();
            SuppliersPostalCity = new HashSet<Supplier>();
            SystemParametersDeliveryCity = new HashSet<SystemParameter>();
            SystemParametersPostalCity = new HashSet<SystemParameter>();
        }

        public string CityName { get; set; }
        public int StateProvinceId { get; set; }

        //public DbGeography Location { get; set; }
        public long? LatestRecordedPopulation { get; set; }

        public int? LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public virtual Person LastEditedByNavigation { get; set; }
        public virtual StateProvince StateProvince { get; set; }
        public virtual ICollection<Customer> CustomersDeliveryCity { get; set; }
        public virtual ICollection<Customer> CustomersPostalCity { get; set; }
        public virtual ICollection<Supplier> SuppliersDeliveryCity { get; set; }
        public virtual ICollection<Supplier> SuppliersPostalCity { get; set; }
        public virtual ICollection<SystemParameter> SystemParametersDeliveryCity { get; set; }
        public virtual ICollection<SystemParameter> SystemParametersPostalCity { get; set; }
    }
}