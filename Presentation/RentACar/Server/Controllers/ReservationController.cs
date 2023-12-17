using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Application.DTOs;
using RentACar.Application.IServices;
using RentACar.Application.ResponseModels;
using RentACar.Persistence.Services;

namespace RentACar.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService reservationService;

        public ReservationController(IReservationService _reservationService)
        {
            reservationService = _reservationService;
        }

        [HttpGet("Locations")]
        public async Task<ServiceResponse<List<ReservationDTO>>> GeReservations()
        {
            return new ServiceResponse<List<ReservationDTO>>()
            {

                Value = await reservationService.GetReservations()
            };
        }
        [HttpPost("Create")]
        public async Task<ServiceResponse<ReservationDTO>> CreateReservation([FromBody] ReservationDTO Reservation)
        {
            return new ServiceResponse<ReservationDTO>()
            {
                Value = await reservationService.CreateReservation(Reservation)
            };
        }
        [HttpPost("Update")]
        public async Task<ServiceResponse<ReservationDTO>> UpdateReservation([FromBody] ReservationDTO Reservation)
        {
            return new ServiceResponse<ReservationDTO>()
            {
                Value = await reservationService.UpdateReservation(Reservation)
            };
        }
        [HttpPost("Delete")]
        public async Task<ServiceResponse<bool>> DeleteReservation([FromBody] Guid Id)
        {
            return new ServiceResponse<bool>()
            {
                Value = await reservationService.DeleteReservation(Id)
            };
        }
        [HttpGet("CarById/{Id}")]
        public async Task<ServiceResponse<ReservationDTO>> GetReservationById(Guid Id)
        {
            return new ServiceResponse<ReservationDTO>()
            {
                Value = await reservationService.GetReservationById(Id)
            };
        }
    }
}
