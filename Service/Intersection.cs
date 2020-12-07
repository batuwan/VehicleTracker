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
        1- Hareket kayıtlı mı?
        2- Bölgenin içinde mi dışında mı?
        3- Eğer içeride ise; Son kayıt çıkış ise, giriş kaydet. Aksi takdirde yoksay.
        4- Eğer dışarıda ise; son kayıt giriş ise, çıkış kaydet. Aksi takdirde yoksay.
        
        
        */



        // Do these two geometries intersects? True or false.
        public bool isIntersects(Geometry g1, Geometry g2)
        {
            return g1.Intersects(g2);

        }




    }
}
