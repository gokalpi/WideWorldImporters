using System;
using System.Collections.Generic;
using WideWorldImporters.Core.Interfaces;

namespace WideWorldImporters.Core.Entities.Application
{
    public class StateProvince : IAuditableEntity
    {
        public StateProvince()
        {
            Cities = new HashSet<City>();
        }

        public int Id { get; set; }
        public string StateProvinceCode { get; set; }
        public string StateProvinceName { get; set; }
        public int CountryId { get; set; }
        public string SalesTerritory { get; set; }

        //public DbGeography Border { get; set; }
        public long? LatestRecordedPopulation { get; set; }

        public int? LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public virtual Country Country { get; set; }
        public virtual Person LastEditedByNavigation { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}