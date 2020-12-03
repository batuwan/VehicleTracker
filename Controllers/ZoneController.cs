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
    public class ZoneController : ControllerBase
    {
        private readonly IZoneService _zoneService;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public ZoneController(IZoneService zoneService, IMapper mapper, IUnitOfWork unitOfWork )

        {
            _unitOfWork = unitOfWork;
            _zoneService = zoneService;
            _mapper = mapper;
        }

        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            var zones = await _zoneService.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<ZoneDTO>>(zones));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var zone = await _zoneService.GetByIdAsync(id);
            return Ok(_mapper.Map<ZoneDTO>(zone));
        }

        [HttpPost]
        public async Task<IActionResult> Save(ZoneDTO zoneDTO)
        {
            var newZone = await _zoneService.AddAsync(_mapper.Map<Zone>(zoneDTO));

            return Created(string.Empty, _mapper.Map<ZoneDTO>(newZone));
        }



        [HttpPut]
        public IActionResult Update(ZoneDTO zoneDTO)

        {
            var zone = _zoneService.Update(_mapper.Map<Zone>(zoneDTO));

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var zone = _zoneService.GetByIdAsync(id).Result;
            _zoneService.Remove(zone);
            _unitOfWork.Commit();

            return NoContent();
        }
    }
}
