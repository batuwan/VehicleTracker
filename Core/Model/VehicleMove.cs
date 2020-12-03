using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleTracker.Core.Model
{
    public class VehicleMove
    {
        public int Id { get; set; }
        public Geometry Geom { get; set; }

        public DateTime Date_ { get; set; }

        public int Velocity { get; set; }
        public int VehicleId { get; set; }

        public virtual Vehicle Vehicle { get; set; }


    }
}
