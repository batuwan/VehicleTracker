using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VehicleTracker.Core.Model;
using VehicleTracker.Core.Service;
using VehicleTracker.Core.UnitOfWork;

namespace VehicleTracker.Service
{
    public class VehicleService : IVehicleService
    {
        private readonly IUnitOfWork _unitOfWork;

        public VehicleService(IUnitOfWork _unitOfWork)
        {

        }
        public Task<Vehicle> AddAsync(Vehicle entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Vehicle>> AddRangeAsync(IEnumerable<Vehicle> entities)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Vehicle>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<Vehicle> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Vehicle entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Vehicle> entities)
        {
            throw new NotImplementedException();
        }

        public Task<Vehicle> SingleOrDefaultAsync(Expression<Func<Vehicle, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Vehicle>> Where(Expression<Func<Vehicle, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
