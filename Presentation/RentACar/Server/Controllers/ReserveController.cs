using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Application.DTOs;
using RentACar.Application.IServices;
using RentACar.Application.ResponseModels;

namespace RentACar.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReserveController : ControllerBase
    {
        private readonly IReservationService reservationService;
        public ReserveController(IReservationService _reservationService)
        {
            reservationService = _reservationService;
        }
        [HttpGet("Reservations")]
        public async Task<ServiceResponse<List<ReservationDTO>>> GetReservations()
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
        [HttpPost("CreateNullToken")]
        [AllowAnonymous]
        public async Task<ServiceResponse<ReservationDTO>> CreateReservationNullToken([FromBody] ReservationDTO Reservation)
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
        [HttpGet("ReservationById/{Id}")]
        public async Task<ServiceResponse<ReservationDTO>> GetReservationById(Guid Id)
        {
            return new ServiceResponse<ReservationDTO>()
            {
                Value = await reservationService.GetReservationById(Id)
            };
        }
    }
}
