using NetTopologySuite.Features;
using NetTopologySuite.Geometries;
using NetTopologySuite.IO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;

namespace VehicleTracker.Mapper
{
    public static class GeoJSONConvert
    {
        //#region Methods

        /// <summary>
        /// The FeatureToGeometry
        /// </summary>
        /// <param name="geoJSON">The geoJSON<see cref="string"/></param>
        /// <returns>The <see cref="T"/></returns>
        public static Geometry FeatureToGeometry(string geoJSON)
        {
            GeoJsonReader reader = new GeoJsonReader();
            var geom = reader.Read<Feature>(geoJSON);
            geom.Geometry.SRID = 4326;
            return geom.Geometry;
        }

        public static Geometry geoJSONToGeometry(string geoJSON)
        {
            Geometry geometry;

            var serializer = GeoJsonSerializer.Create();
            using (var stringReader = new System.IO.StringReader(geoJSON))
            using (var jsonReader = new JsonTextReader(stringReader))
            {
                geometry = serializer.Deserialize<Geometry>(jsonReader);
            }
            return geometry;

        }


        public class DoubleConverter : JsonConverter<double>
        {
            public override double ReadJson(JsonReader reader, Type objectType, [AllowNull] double existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
            {
                throw new NotImplementedException();
            }

            public override void WriteJson(JsonWriter writer, [AllowNull] double value, Newtonsoft.Json.JsonSerializer serializer)
            {
                throw new NotImplementedException();
            }
        }
    }
}
