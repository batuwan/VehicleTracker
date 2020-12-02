using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleTracker.Core.Model
{
    public class ZoneRecord
    {
        public int Id { get; set; }
        public int? VehicleId { get; set; }
        public int VehicleMoveId { get; set; }
        public int ZoneId { get; set; }
        public DateTime Date_ { get; set; }
        public bool RecordType { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual VehicleMove VehicleMove { get; set; }
        public virtual Zone Zone { get; set; }
    }
}
