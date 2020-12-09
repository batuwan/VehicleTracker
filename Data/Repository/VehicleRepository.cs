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

        public async Task<Vehicle> GetWithRecordsByIdAsync(int vehicleID, DateTime startDate, DateTime endDate)
        {   var vehicles = await _appDbContext.Vehicles.Include(x => x.ZoneRecords.Where(y => (y.Date_ >= startDate) && (y.Date_ <= endDate))).SingleOrDefaultAsync(x => x.Id == vehicleID);
            
            return vehicles;

        }

        public async Task<Vehicle> GetWithMovementsByIdAsync(int vehicleID, DateTime startDate, DateTime endDate)
        {
            var vehicles = await _appDbContext.Vehicles.Include(x => x.VehicleMoves.Where(y => (y.Date_ >= startDate) && (y.Date_ <= endDate))).SingleOrDefaultAsync(x => x.Id == vehicleID);
            return vehicles;
        }   
    }
}
