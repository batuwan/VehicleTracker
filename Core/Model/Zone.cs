using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleTracker.Core.Model
{
    public class Zone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Geometry Geom { get; set; }

        public ICollection<ZoneRecord> ZoneRecords { get; set; }
    }
}
