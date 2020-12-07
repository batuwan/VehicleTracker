using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VehicleTracker.Core.IRepository;
using VehicleTracker.Core.Model;
using VehicleTracker.Core.Service;
using VehicleTracker.Core.UnitOfWork;
using VehicleTracker.Data;
using VehicleTracker.Data.Repository;

namespace VehicleTracker.Service
{
    public class ZoneRecordService : Service<ZoneRecord>, IZoneRecordService
    {
        private readonly IZoneRecordRepository _repository;
        private readonly IVehicleMoveService vehicleMoveService;
        private readonly IZoneService zoneService;
        //private readonly IZoneRepository zoneRepository;
        public ZoneRecordService(IUnitOfWork unitOfWork, IZoneRecordRepository repository, IZoneService zoneService, IVehicleMoveService vehicleMoveService) : base(unitOfWork, repository)
        {
            _repository = repository;
            this.vehicleMoveService = vehicleMoveService;
            this.zoneService = zoneService;
        }

        public async Task<ZoneRecord> SaveRecordAsync(int vehicleMoveId, int zoneId)
        {
            //Hareket kayıtlı mı?
            if (!(_repository.IsVehicleExistInZoneRecorsTable(vehicleMoveId)))
            {
                return null;
            }
            VehicleMove vehicleMove = await vehicleMoveService.GetByIdAsync(vehicleMoveId);
            Zone zone = await zoneService.GetByIdAsync(zoneId);

            //Bölgenin içinde mi dışında mı?
            var intersection = IsIntersects(vehicleMove.Geom, zone.Geom);

            //Araç ID'sini al, Tarihe göre son kayıdı getir.
            ZoneRecord lastRecord = await _repository.GetLastRecordOfAVehicleByDate(vehicleMove.VehicleId);

            ZoneRecord newZoneRecord = new ZoneRecord();

            if (!(_repository.IsVehicleExistInZoneRecorsTable(vehicleMoveId)))
            {
                if (intersection)
                {
                    newZoneRecord.ZoneId = zoneId;
                    newZoneRecord.VehicleMoveId = vehicleMoveId;
                    newZoneRecord.Date_ = vehicleMove.Date_;
                    newZoneRecord.VehicleId = vehicleMove.VehicleId;
                    newZoneRecord.RecordType = true;
                    return await AddAsync(newZoneRecord);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                //Tarih kontrolü
                /*if (!(IsInputDateBiggerThanLastRecordsDate(vehicleMove.Date_, lastRecord.Date_)))
                {
                    return null;
                }*/


                //İçerideyse
                if (intersection)
                {

                    //Son kayıt çıkışsa giriş olarak kaydet.
                    if (lastRecord.RecordType == false)
                    {
                        newZoneRecord.ZoneId = zoneId;
                        newZoneRecord.VehicleMoveId = vehicleMoveId;
                        newZoneRecord.Date_ = vehicleMove.Date_;
                        newZoneRecord.VehicleId = vehicleMove.VehicleId;
                        newZoneRecord.RecordType = true;
                        return await AddAsync(newZoneRecord);
                    }

                }

                //Dışarıdaysa
                if (!intersection)
                {

                    //Son kayıt girişse çıkış olarak kaydet.
                    if (!(lastRecord == null) && lastRecord.RecordType == true)
                    {
                        newZoneRecord.ZoneId = zoneId;
                        newZoneRecord.VehicleMoveId = vehicleMoveId;
                        newZoneRecord.Date_ = vehicleMove.Date_;
                        newZoneRecord.VehicleId = vehicleMove.VehicleId;
                        newZoneRecord.RecordType = false;
                        return await AddAsync(newZoneRecord);
                    }

                }
            }


            return null;

        }


        public bool IsIntersects(Geometry g1, Geometry g2)
        {
            return g1.Intersects(g2);

        }

        // Kaydedilmek istenen kayıt son kayıttan daha mı yeni?
        public bool IsInputDateBiggerThanLastRecordsDate(DateTime inputDate, DateTime lastRecordsDate)
        {
            return inputDate > lastRecordsDate;
        }


        /*
        1- Hareket kayıtlı mı? OK
        2- Bölgenin içinde mi dışında mı? 
        3- Eğer içeride ise; Son kayıt çıkış ise, giriş kaydet. Aksi takdirde yoksay.
        4- Eğer dışarıda ise; son kayıt giriş ise, çıkış kaydet. Aksi takdirde yoksay.
        
        
        */

        //TODO: Bölge kayıtlarına özel metotlar?
    }
}
