using System;
using WideWorldImporters.Core.Interfaces;

namespace WideWorldImporters.Core.Entities.Warehouse
{
    public class ColdRoomTemperature : IEntity
    {
        public long Id { get; set; }
        public int ColdRoomSensorNumber { get; set; }
        public DateTime RecordedWhen { get; set; }
        public decimal Temperature { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
    }
}