using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleTracker.Core.Model
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Plate { get; set; }
        public ICollection<VehicleMove> VehicleMoves { get; set; }

        public ICollection<ZoneRecord> ZoneRecords { get; set; }
    }
}
