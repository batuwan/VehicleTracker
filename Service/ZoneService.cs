using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VehicleTracker.Core.Model;
using VehicleTracker.Core.Service;

namespace VehicleTracker.Service
{
    public class ZoneService : IZoneService
    {
        public Task<Zone> AddAsync(Zone entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Zone>> AddRangeAsync(IEnumerable<Zone> entities)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Zone>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<Zone> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Zone entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Zone> entities)
        {
            throw new NotImplementedException();
        }

        public Task<Zone> SingleOrDefaultAsync(Expression<Func<Zone, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Zone>> Where(Expression<Func<Zone, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
