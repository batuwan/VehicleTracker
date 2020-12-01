using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VehicleTracker.Core.Model;
using VehicleTracker.Core.Service;

namespace VehicleTracker.Service
{
    public class VehicleMoveService : IVehicleMoveService
    {
        public Task<VehicleMove> AddAsync(VehicleMove entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<VehicleMove>> AddRangeAsync(IEnumerable<VehicleMove> entities)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<VehicleMove>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<VehicleMove> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(VehicleMove entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<VehicleMove> entities)
        {
            throw new NotImplementedException();
        }

        public Task<VehicleMove> SingleOrDefaultAsync(Expression<Func<VehicleMove, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<VehicleMove>> Where(Expression<Func<VehicleMove, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
