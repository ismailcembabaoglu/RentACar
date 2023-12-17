using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors.Infrastructure;
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
    public class CarLocationController : ControllerBase
    {
        private readonly ICarLocationService carLocationService;

        public CarLocationController(ICarLocationService _carLocationService)
        {
            carLocationService = _carLocationService;
        }

        [HttpGet("CarLocations")]
        public async Task<ServiceResponse<List<CarLocationDTO>>> GetCarLocations()
        {
            return new ServiceResponse<List<CarLocationDTO>>()
            {

                Value = await carLocationService.GetCarLocations()
            };
        }
        [HttpPost("Create")]
        public async Task<ServiceResponse<CarLocationDTO>> CreateCarLocation([FromBody] CarLocationDTO CarLocation)
        {
            return new ServiceResponse<CarLocationDTO>()
            {
                Value = await carLocationService.CreateCarLocation(CarLocation)
            };
        }
        [HttpPost("Update")]
        public async Task<ServiceResponse<CarLocationDTO>> UpdateCarLocation([FromBody] CarLocationDTO CarLocation)
        {
            return new ServiceResponse<CarLocationDTO>()
            {
                Value = await carLocationService.UpdateCarLocation(CarLocation)
            };
        }
        [HttpPost("Delete")]
        public async Task<ServiceResponse<bool>> DeleteCarLocationId([FromBody] Guid Id)
        {
            return new ServiceResponse<bool>()
            {
                Value = await carLocationService.DeleteCarLocationId(Id)
            };
        }
        [HttpGet("CarById/{Id}")]
        public async Task<ServiceResponse<CarLocationDTO>> GetCarLocationById(Guid Id)
        {
            return new ServiceResponse<CarLocationDTO>()
            {
                Value = await carLocationService.GetCarLocationById(Id)
            };
        }
    }
}
