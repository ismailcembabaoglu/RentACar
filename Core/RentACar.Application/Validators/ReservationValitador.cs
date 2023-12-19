using FluentValidation;
using RentACar.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Application.Validators
{
    public class ReservationValitador : AbstractValidator<ReservationDTO>
    {
        public ReservationValitador() 
        {
            RuleFor(c => c.RentPrice).NotEmpty().WithMessage("Kiralık Fiyat Boş Geçilemez!!");
            RuleFor(c => c.TotalPrice).NotEmpty().WithMessage("Toplam Fiyat Boş Geçilemez!!");

        }   

    }
}
