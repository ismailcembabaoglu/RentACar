using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Domain.Mappings
{
    public class LocationMap : IEntityTypeConfiguration<Location>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Location> builder)
        {
            
        }
    }
}
