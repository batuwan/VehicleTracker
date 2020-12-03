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
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public VehicleController(IVehicleService vehicleService, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _vehicleService = vehicleService;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
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

        [HttpPut]
        public IActionResult Update(VehicleDTO vehicleDTO)

        {
            var vehicle = _vehicleService.Update(_mapper.Map<Vehicle>(vehicleDTO));

            return NoContent();
        }

        //?????
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var vehicle = _vehicleService.GetByIdAsync(id).Result;
            _vehicleService.Remove(vehicle);
            _unitOfWork.Commit();

            return NoContent();
        }
    }
}
