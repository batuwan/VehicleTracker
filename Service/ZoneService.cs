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
    public class ZoneService : Service<Zone>, IZoneService
    {
        public ZoneService(IUnitOfWork unitOfWork, IRepository<Zone> repository) : base(unitOfWork, repository)
        {

        }

        //TODO: Bölgeye özel metotlar?
    }
}
