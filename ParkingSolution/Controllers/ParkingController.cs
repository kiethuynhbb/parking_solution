using App.Services.RepositoryPattern;
using App.Services.ViewModels;
using AutoMapper.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingSolution.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ParkingController : ControllerBase
    {

        private readonly IVehicleService _vehicelService;
        private readonly IParkingService _parkingService;

        public ParkingController(IVehicleService vehicelService, IParkingService parkingService)
        {
            _vehicelService = vehicelService;

            _parkingService = parkingService;
        }

        [HttpPost(nameof(EnterVehicle))]
        public async Task<IActionResult> EnterVehicle(string license, int level, int cardNo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await _parkingService.Assign(license, level, cardNo);
                    return Ok(result);
                }
                else
                {
                    return BadRequest("Please fill all the required parameters");
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
                throw;
            }
        }

        [HttpPost(nameof(ExitVehicle))]
        public async Task<IActionResult> ExitVehicle(string license, int level, int cardNo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = _parkingService.ReAssign(license, level, cardNo);
                    return Ok(result);
                }
                else
                {
                    return BadRequest("Please fill all the required parameters");
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
                throw;
            }
        }

        public async Task<List<VehicleDto>> GetVehicleAsync()
        {

            try
            {
                if (ModelState.IsValid)
                {
                    var result = await _vehicelService.GetVehicles();
                    return result;
                }
                else
                {
                    return new List<VehicleDto>();
                }

            }
            catch (Exception ex)
            {
                return null;
                throw;
            }
        }
    }
}
