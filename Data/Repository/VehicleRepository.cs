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

        public Task<IEnumerable<Vehicle>> GetAllWithRecordsAsync()
        {
            return null; //TODO
        }
    }
}
