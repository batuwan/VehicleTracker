using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTracker.Core.IRepository;
using VehicleTracker.Core.UnitOfWork;

namespace VehicleTracker.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        //TODO: 

        public IVehicleRepository Vehicles => throw new NotImplementedException();

        public IZoneRepository Zones => throw new NotImplementedException();

        public IVehicleMoveRepository VehicleMoves => throw new NotImplementedException();

        public IZoneRecordRepository ZoneRecords => throw new NotImplementedException();
    }
}
