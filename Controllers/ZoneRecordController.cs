using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTracker.Core.Model;
using VehicleTracker.Core.Service;
using VehicleTracker.Core.UnitOfWork;
using VehicleTracker.DTOs;

namespace VehicleTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZoneRecordController : ControllerBase
    {

        private readonly IZoneRecordService _zoneRecordService;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public ZoneRecordController(IZoneRecordService zoneRecordService, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _zoneRecordService = zoneRecordService;
            _mapper = mapper;
            _unitOfWork = unitOfWork;

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var zoneRecords = await _zoneRecordService.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<ZoneRecordDTO>>(zoneRecords));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var zoneRecord = await _zoneRecordService.GetByIdAsync(id);
            return Ok(_mapper.Map<ZoneRecordDTO>(zoneRecord));
        }
        [HttpPost]
        public async Task<IActionResult> Save(int vehicleMoveId, int zoneId)
        {
            var newZoneRecord = _zoneRecordService.SaveRecordAsync(vehicleMoveId, zoneId);
            ZoneRecordDTO zoneRecordDTO =_mapper.Map<ZoneRecordDTO>(newZoneRecord);

            return Created(string.Empty, zoneRecordDTO);
        }

        [HttpPut]
        public IActionResult Update(ZoneRecordDTO zoneRecordDTO)

        {
            var zoneRecord = _zoneRecordService.Update(_mapper.Map<ZoneRecord>(zoneRecordDTO));

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var zoneRecord = _zoneRecordService.GetByIdAsync(id).Result;
            _zoneRecordService.Remove(zoneRecord);

            return NoContent();
        }
    }
}
