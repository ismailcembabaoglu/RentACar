﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Application.DTOs;
using RentACar.Application.IServices;
using RentACar.Application.ResponseModels;
using RentACar.Persistence.Services;
using RentACarLocation.Application.IServices;

namespace RentACar.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService locationService;

        public LocationController(ILocationService _locationService)
        {
            locationService = _locationService;
        }

        [HttpGet("Locations")]
        public async Task<ServiceResponse<List<LocationDTO>>> GetLocations()
        {
            return new ServiceResponse<List<LocationDTO>>()
            {

                Value = await locationService.GetLocations()
            };
        }
        [HttpPost("Create")]
        public async Task<ServiceResponse<LocationDTO>> CreateLocation([FromBody] LocationDTO Location)
        {
            return new ServiceResponse<LocationDTO>()
            {
                Value = await locationService.CreateLocation(Location)
            };
        }
        [HttpPost("Update")]
        public async Task<ServiceResponse<LocationDTO>> UpdateLocation([FromBody] LocationDTO Location)
        {
            return new ServiceResponse<LocationDTO>()
            {
                Value = await locationService.UpdateLocation(Location)
            };
        }
        [HttpPost("Delete")]
        public async Task<ServiceResponse<bool>> DeleteLocationId([FromBody] Guid Id)
        {
            return new ServiceResponse<bool>()
            {
                Value = await locationService.DeleteLocationId(Id)
            };
        }
        [HttpGet("CarById/{Id}")]
        public async Task<ServiceResponse<LocationDTO>> GetLocationById(Guid Id)
        {
            return new ServiceResponse<LocationDTO>()
            {
                Value = await locationService.GetLocationById(Id)
            };
        }


    }
}