﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTracker.Core.Model;

namespace VehicleTracker.Core.IRepository
{
    interface IVehicleRepository : IRepository<Vehicle>

    {
        Task<IEnumerable<Vehicle>> GetAllWithRecordsAsync();

    }
}
