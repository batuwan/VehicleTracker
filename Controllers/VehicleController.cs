using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleTracker.Core.Model;
using VehicleTracker.Core.Service;
using VehicleTracker.DTOs;

namespace VehicleTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;
        private readonly IMapper _mapper;

        public VehicleController(IVehicleService vehicleService, IMapper mapper)
        {
            _vehicleService = vehicleService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vehicles = await _vehicleService.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<VehicleDTO>>(vehicles));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var vehicle = await _vehicleService.GetByIdAsync(id);
            return Ok(_mapper.Map<VehicleDTO>(vehicle));
        }

        [HttpPost]
        public async Task<IActionResult> Save(VehicleDTO vehicleDTO)
        {
            var newVehicle = await _vehicleService.AddAsync(_mapper.Map<Vehicle>(vehicleDTO));

            return Created(string.Empty, _mapper.Map<VehicleDTO>(newVehicle));
        }
    }
}
