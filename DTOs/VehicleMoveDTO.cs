using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleTracker.DTOs
{
    public class VehicleMoveDTO
    {
        //  public int Id { get; set; }

        // public NetTopologySuite.Geometries.Point Geom { get; set; }

        public double latitude { get; set; }
        public double longitude { get; set; }
        public int srid { get; set; }
        public DateTime Date_ { get; set; }

        public int Velocity { get; set; }
        public int VehicleId { get; set; }
    }
}


