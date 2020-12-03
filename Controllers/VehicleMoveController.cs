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
    public class VehicleMoveController : ControllerBase
    {
        private readonly IVehicleMoveService _vehicleMoveService;
        private readonly IMapper _mapper;

        public VehicleMoveController(IVehicleMoveService vehicleMoveService, IMapper mapper)
        {
            _vehicleMoveService = vehicleMoveService;
            _mapper = mapper;

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var vehicleMoves = await _vehicleMoveService.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<VehicleMoveDTO>>(vehicleMoves));
        }
    }
}
