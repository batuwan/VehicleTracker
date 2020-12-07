using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTracker.Core.Model;

namespace VehicleTracker.Core.Service
{
    public interface IZoneRecordService : IService<ZoneRecord>
    {
        //TODO: 
        Task<ZoneRecord> SaveRecordAsync(int vehicleMoveId, int zoneId);
    }
}
