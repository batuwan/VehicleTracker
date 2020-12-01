using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTracker.Core.IRepository;

namespace VehicleTracker.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        IVehicleRepository Vehicles { get; }
        IZoneRepository Zones { get; }
        IVehicleMoveRepository VehicleMoves { get; }
        IZoneRecordRepository ZoneRecords { get; }

    }
}
