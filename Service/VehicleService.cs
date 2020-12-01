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

        //TODO: Araca özel metotlar?
    }
}
