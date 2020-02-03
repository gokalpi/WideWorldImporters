using System;

namespace WideWorldImporters.Core.Entities.Warehouse
{
    public partial class ColdRoomTemperature : Entity<long>
    {
        public int ColdRoomSensorNumber { get; set; }
        public DateTime RecordedWhen { get; set; }
        public decimal Temperature { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
    }
}