﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleTracker.DTOs
{
    public class VehicleWithMovementsDTO : VehicleDTO
    {
        public ICollection<VehicleMoveDTO> VehicleMoves { get; set; }
    }
}
