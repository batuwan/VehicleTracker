using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTracker.Core.Service;
using VehicleTracker.DTOs;

namespace VehicleTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZoneRecordController : ControllerBase
    {

        private readonly IZoneRecordService _zoneRecordService;
        private readonly IMapper _mapper;

        public ZoneRecordController(IZoneRecordService zoneRecordService, IMapper mapper)
        {
            _zoneRecordService = zoneRecordService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var zoneRecords = await _zoneRecordService.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<ZoneRecordDTO>>(zoneRecords));
        }
    }
}
