using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleTracker.DTOs
{
    public class ZoneDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public NetTopologySuite.Geometries.Polygon Geom { get; set; }
    }
}
