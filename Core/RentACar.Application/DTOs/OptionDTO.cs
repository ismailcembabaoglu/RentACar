using RentACar.Domain.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Application.DTOs
{
    public class OptionDTO:BaseModel
    {
        public string OpsiyonName { get; set; }
        public decimal OpsiyonPrice { get; set; }
    }
}
