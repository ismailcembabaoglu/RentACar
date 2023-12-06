using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Persistence.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<RentACarPsqlDbContext>
    {
        public RentACarPsqlDbContext CreateDbContext(string[] args)
        {
            ConfigurationManager configurationManager = new ConfigurationManager();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/RentACar/Server"));
            configurationManager.AddJsonFile("appsettings.json");
            var builder = new DbContextOptionsBuilder<RentACarPsqlDbContext>();
            builder.UseNpgsql(configurationManager.GetConnectionString("PostgreSql"));
            return new RentACarPsqlDbContext(builder.Options);
        }
    }
}
