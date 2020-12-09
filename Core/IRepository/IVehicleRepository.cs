using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTracker.Core.Model;

namespace VehicleTracker.Core.IRepository
{
    public interface IVehicleRepository : IRepository<Vehicle>

    {
        Task<Vehicle> GetWithRecordsByIdAsync(int vehicleID, DateTime startDate, DateTime endDate);
        Task<Vehicle> GetWithMovementsByIdAsync(int vehicleID);
        
    }
}
