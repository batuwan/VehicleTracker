using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VehicleTracker.Core.Model;
using VehicleTracker.Core.Service;

namespace VehicleTracker.Service
{
    public class ZoneRecordService : IZoneRecordService
    {
        public Task<ZoneRecord> AddAsync(ZoneRecord entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ZoneRecord>> AddRangeAsync(IEnumerable<ZoneRecord> entities)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ZoneRecord>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<ZoneRecord> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(ZoneRecord entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<ZoneRecord> entities)
        {
            throw new NotImplementedException();
        }

        public Task<ZoneRecord> SingleOrDefaultAsync(Expression<Func<ZoneRecord, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ZoneRecord>> Where(Expression<Func<ZoneRecord, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
