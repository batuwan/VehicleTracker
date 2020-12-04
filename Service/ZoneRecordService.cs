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
    public class ZoneRecordService : Service<ZoneRecord>, IZoneRecordService
    {
        public ZoneRecordService(IUnitOfWork unitOfWork, IRepository<ZoneRecord> repository) : base(unitOfWork, repository)
        {
        }

        



        //TODO: Bölge kayıtlarına özel metotlar?
    }
}
