using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTracker.Core.IRepository;
using VehicleTracker.Core.UnitOfWork;
using VehicleTracker.Data.Repository;

namespace VehicleTracker.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        private VehicleMoveRepository _vehicleMoveRepository;
        private VehicleRepository _vehicleRepository;
        private ZoneRepository _zoneRepository;
        private ZoneRecordRepository _zoneRecordRepository;
        //TODO: 

        IVehicleRepository IUnitOfWork.Vehicles => _vehicleRepository = _vehicleRepository ?? new VehicleRepository(_context);

        IZoneRepository IUnitOfWork.Zones => _zoneRepository = _zoneRepository ?? new ZoneRepository(_context);

        IVehicleMoveRepository IUnitOfWork.VehicleMoves => _vehicleMoveRepository = _vehicleMoveRepository ?? new VehicleMoveRepository(_context);

        IZoneRecordRepository IUnitOfWork.ZoneRecords => _zoneRecordRepository = _zoneRecordRepository ?? new ZoneRecordRepository(_context);

        public UnitOfWork(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
