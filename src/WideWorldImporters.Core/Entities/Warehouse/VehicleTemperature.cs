using System;
using WideWorldImporters.Core.Interfaces;

namespace WideWorldImporters.Core.Entities.Warehouse
{
    public class VehicleTemperature : IEntity
    {
        public long Id { get; set; }
        public string VehicleRegistration { get; set; }
        public int ChillerSensorNumber { get; set; }
        public DateTime RecordedWhen { get; set; }
        public decimal Temperature { get; set; }
        public bool IsCompressed { get; set; }
        public string FullSensorData { get; set; }
        public byte[] CompressedSensorData { get; set; }
    }
}