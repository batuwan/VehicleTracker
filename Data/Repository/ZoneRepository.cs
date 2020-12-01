using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTracker.Core.IRepository;
using VehicleTracker.Core.Model;

namespace VehicleTracker.Data.Repository
{
    public class ZoneRepository : Repository<Zone>, IZoneRepository
    {
        private AppDbContext _appDbContext { get => _context as AppDbContext; }

        public ZoneRepository(AppDbContext context) : base(context)
        {

        }
    }
}
