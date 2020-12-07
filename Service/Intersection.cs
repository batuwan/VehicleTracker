using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleTracker.Service
{
    public class Intersection
    {
       /*
        
        
        
        */



        // Do these two geometries intersects? True or false.
        public bool isIntersects(Geometry g1, Geometry g2)
        {
            return g1.Intersects(g2);

        }




    }
}
