using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTracker.Core.IRepository;
using VehicleTracker.Core.Model;

namespace VehicleTracker.Data.Repository
{
    public class VehicleRepository : Repository<Vehicle>, IVehicleRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public VehicleRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Vehicle> GetWithRecordsByIdAsync(int vehicleID)
        {
            return await _appDbContext.Vehicles.Include(x => x.ZoneRecords).SingleOrDefaultAsync(x => x.Id == vehicleID);

        }

        public async Task<Vehicle> GetWithMovementsByIdAsync(int vehicleID)
        {
            return await _appDbContext.Vehicles.Include(x => x.VehicleMoves).SingleOrDefaultAsync(x => x.Id == vehicleID);
        }
    }
}
