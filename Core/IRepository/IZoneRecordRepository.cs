using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTracker.Core.Model;

namespace VehicleTracker.Core.IRepository
{
    public interface IZoneRecordRepository : IRepository<ZoneRecord>
    {
        //TODO:

        Task<ZoneRecord> GetLastRecordOfAVehicleByDate(int vehicleID);

        bool IsVehicleExistInZoneRecordsTable(int vehicleID);
    }
}
