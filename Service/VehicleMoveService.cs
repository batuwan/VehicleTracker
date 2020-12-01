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
    public class VehicleMoveService : Service<VehicleMove>, IVehicleMoveService
    {
        public VehicleMoveService(IUnitOfWork unitOfWork, IRepository<VehicleMove> repository) : base(unitOfWork, repository)
        {
        }

        //TODO: Hareket için özel metotlar?
    }
}
