using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTracker.Core.IRepository;
using VehicleTracker.Core.Model;

namespace VehicleTracker.Data.Repository
{
    public class ZoneRecordRepository : Repository<ZoneRecord>, IZoneRecordRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public ZoneRecordRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<Vehicle> GetWithRecordsByIdAsync(int vehicleID)
        {
            return await _appDbContext.Vehicles.Include(x => x.ZoneRecords).SingleOrDefaultAsync(x => x.Id == vehicleID);

        }

        public async Task<ZoneRecord> GetLastRecordOfAVehicleByDate(int vehicleID)
        {
            return await _appDbContext.ZoneRecords.OrderByDescending(r => r.Date_).SingleOrDefaultAsync();
        }
    }
}
