using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleTracker.DTOs
{
    public class ZoneRecordDTO
    {
        public int Id { get; set; }
        public int? VehicleId { get; set; }
        public int VehicleMoveId { get; set; }
        public int ZoneId { get; set; }
        public DateTime Date_ { get; set; }
       // public bool RecordType { get; set; }
    }
}
