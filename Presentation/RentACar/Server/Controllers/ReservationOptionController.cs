﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentACar.Application.DTOs;
using RentACar.Application.IServices;
using RentACar.Persistence.ResponseModels;
using RentACar.Persistence.Services;

namespace RentACar.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ReservationOptionController : ControllerBase
    {
        private readonly IReservationOptionService reservationOptionService;

        public ReservationOptionController(IReservationOptionService _reservationOptionService)
        {
            reservationOptionService = _reservationOptionService;
        }

        [HttpGet("ReservationOptions")]
        public async Task<ServiceResponse<List<ReservationOptionDTO>>> GetReservationOptions()
        {
            return new ServiceResponse<List<ReservationOptionDTO>>()
            {

                Value = await reservationOptionService.GetReservationOptions()
            };
        }
        [HttpPost("Create")]
        public async Task<ServiceResponse<ReservationOptionDTO>> CreateReservationOption([FromBody] ReservationOptionDTO ReservationOption)
        {
            return new ServiceResponse<ReservationOptionDTO>()
            {
                Value = await reservationOptionService.CreateReservationOption(ReservationOption)
            };
        }
        [HttpPost("Update")]
        public async Task<ServiceResponse<ReservationOptionDTO>> UpdateReservationOption([FromBody] ReservationOptionDTO ReservationOption)
        {
            return new ServiceResponse<ReservationOptionDTO>()
            {
                Value = await reservationOptionService.UpdateReservationOption(ReservationOption)
            };
        }
        [HttpPost("Delete")]
        public async Task<ServiceResponse<bool>> DeleteReservationOptionId([FromBody] Guid Id)
        {
            return new ServiceResponse<bool>()
            {
                Value = await reservationOptionService.DeleteReservationOptionId(Id)
            };
        }
        [HttpGet("CarById/{Id}")]
        public async Task<ServiceResponse<ReservationOptionDTO>> GetReservationOptionById(Guid Id)
        {
            return new ServiceResponse<ReservationOptionDTO>()
            {
                Value = await reservationOptionService.GetReservationOptionById(Id)
            };
        }

    }
}
