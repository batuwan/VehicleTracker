using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTracker.Core.Model;

namespace VehicleTracker.Core.Service
{
    public interface IVehicleService : IService<Vehicle>
    {
        Task<Vehicle> GetWithRecordsByIdAsync(int vehicleId, DateTime startDate, DateTime endDate);
        Task<Vehicle> GetWithMovementsByIdAsync(int vehicleId, DateTime startDate, DateTime endDate);


    }
}
