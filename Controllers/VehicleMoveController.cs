using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetTopologySuite.Geometries;
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
    public class VehicleMoveController : ControllerBase
    {
        private readonly IVehicleMoveService _vehicleMoveService;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public VehicleMoveController(IVehicleMoveService vehicleMoveService, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _vehicleMoveService = vehicleMoveService;
            _mapper = mapper;
            _unitOfWork = unitOfWork;

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vehicleMoves = await _vehicleMoveService.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<VehicleMoveDTO>>(vehicleMoves));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var vehicle = await _vehicleMoveService.GetByIdAsync(id);
            return Ok(_mapper.Map<VehicleMoveDTO>(vehicle));
        }

        [HttpPost]
        public async Task<IActionResult> Save(VehicleMoveDTO vehicleMoveDTO)
        { var point = _mapper.Map<MyPoint>(vehicleMoveDTO);
            var _vehicleMove = _mapper.Map<VehicleMove>(vehicleMoveDTO);
            _vehicleMove.Geom = point;
            /* _vehicleMove.Geom = new Point(vehicleMoveDTO._x, vehicleMoveDTO._y) { SRID = vehicleMoveDTO.SRID};*/
            var newVehicleMove = await _vehicleMoveService.AddAsync(_vehicleMove);

            return Created(string.Empty, _vehicleMove);
        }

        [HttpPut]
        public IActionResult Update(VehicleMoveDTO vehicleMoveDTO)

        {
            var vehicle = _vehicleMoveService.Update(_mapper.Map<VehicleMove>(vehicleMoveDTO));

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var vehicle = _vehicleMoveService.GetByIdAsync(id).Result;
            _vehicleMoveService.Remove(vehicle);
            _unitOfWork.Commit();

            return NoContent();
        }

        //TODO: Diğer metotlar???
    }
}
