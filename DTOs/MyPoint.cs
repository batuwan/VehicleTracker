using NetTopologySuite.Geometries;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleTracker.DTOs
{
    public class MyPoint : Point
    {
        public double latitude;
        public double longitude;
        public int srid;


        [JsonConstructor]
        public MyPoint(double latitude, double longitude, int srid)
            : base(new NetTopologySuite.Geometries.Coordinate(longitude, latitude)) => SRID = srid;
    }
}
