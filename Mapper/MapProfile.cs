using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTracker.Core.Model;
using VehicleTracker.DTOs;

namespace VehicleTracker.Mapper
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {

            CreateMap<Vehicle, VehicleDTO>();
            CreateMap<VehicleDTO, Vehicle>();

            CreateMap<VehicleMove, VehicleMoveDTO>();
            CreateMap<VehicleMoveDTO, VehicleMove>();

            CreateMap<Zone, ZoneDTO>();
            CreateMap<ZoneDTO, Zone>();

            CreateMap<ZoneRecord, ZoneRecordDTO>();
            CreateMap<ZoneRecordDTO, ZoneRecord>();
            
            CreateMap<Vehicle, VehicleWithRecordsDTO>();
            CreateMap<Vehicle, VehicleWithMovementsDTO>();




        }
    }
}
