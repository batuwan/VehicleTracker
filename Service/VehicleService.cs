using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VehicleTracker.Core.IRepository;
using VehicleTracker.Core.Model;
using VehicleTracker.Core.Service;
using VehicleTracker.Core.UnitOfWork;

namespace VehicleTracker.Service
{
    public class VehicleService : Service<Vehicle>, IVehicleService
    {

        public VehicleService(IUnitOfWork unitOfWork, IRepository<Vehicle> repository) : base(unitOfWork, repository)
        {

        }

        public async Task<Vehicle> GetWithMovementsByIdAsync(int vehicleId)
        {
            return await _unitOfWork.Vehicles.GetWithMovementsByIdAsync(vehicleId);
        }

        public async Task<Vehicle> GetWithRecordsByIdAsync(int vehicleId, DateTime start, DateTime end)
        {

            return await _unitOfWork.Vehicles.GetWithRecordsByIdAsync(vehicleId, start, end);
        }

        //TODO: Araca özel metotlar?
    }
}
