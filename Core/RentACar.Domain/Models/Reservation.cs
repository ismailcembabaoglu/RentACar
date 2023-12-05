using RentACar.Domain.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.Models
{
    public class Reservation:BaseModel
    {
        public Guid CarId { get; set; }
        public virtual Car? Car { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal RentPrice { get; set; }
        public decimal? AdditionalProductPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public ICollection<ReservationOption>? ReservationOptions { get; set; }

    }
}
