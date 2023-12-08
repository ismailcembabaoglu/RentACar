using RentACar.Application.DTOs.BaseModelDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Application.DTOs
{
    public class ReservationDTO:BaseModelDTO
    {
        public Guid CarId { get; set; }
        public string? CarName { get; set; }
        public string? CarModel { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal RentPrice { get; set; }
        public decimal? AdditionalProductPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
