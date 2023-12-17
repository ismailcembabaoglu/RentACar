using FluentValidation;
using RentACar.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Application.Validators
{
    public class CarValidator:AbstractValidator<CarDTO>
    {
        public CarValidator()
        {
            RuleFor(c=>c.CarName).NotEmpty().WithMessage("Araba Adı Boş Geçilemez!!");
            RuleFor(c => c.CarModel).NotEmpty().WithMessage("Araba Modeli Boş Geçilemez!!");
            RuleFor(c => c.Photo).NotEmpty().WithMessage("Fotoğraf Alanı Boş Geçilemez!!");
        }
    }
}
