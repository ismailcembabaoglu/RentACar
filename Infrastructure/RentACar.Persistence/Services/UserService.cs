using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RentACar.Application.DTOs;
using RentACar.Application.IServices;
using RentACar.Domain.Models;
using RentACar.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Persistence.Users
{
    public class UserService : IUserService
    {

        private readonly IMapper mapper;
        private readonly IConfiguration configuration;
        private readonly RentACarPsqlDbContext context;
        public UserService(IMapper _mapper, IConfiguration _configuration, RentACarPsqlDbContext _context)
        {
            mapper = _mapper;
            configuration = _configuration;
            context = _context;
        }
        public async Task<UserDTO> CreateUser(UserDTO User)
        {
            var dbUser = await context.Users.Where(c => c.Id == User.Id).FirstOrDefaultAsync();
            if (dbUser != null)
                throw new Exception("Bu Kullanıcı Zaten Sistemde Kayıtlı");
            dbUser = mapper.Map<User>(User);
            dbUser.CreateDate = DateTime.UtcNow;
            await context.Users.AddAsync(dbUser);
            int result = await context.SaveChangesAsync();

            return mapper.Map<UserDTO>(dbUser);

        }

        public async Task<bool> DeleteUserId(Guid id)
        {
            var dbUser = await context.Users.Where(c => c.Id == id).FirstOrDefaultAsync();
            if (dbUser == null)
                throw new Exception("Kullanıcı Bulunamadı");
            context.Users.Remove(dbUser);
            int result = await context.SaveChangesAsync();
            return result > 0;
        }

        public async Task<UserDTO> GetUserById(Guid Id)
        {
            var dbUser = await context.Users.Where(c => c.Id == Id)
                .ProjectTo<UserDTO>(mapper.ConfigurationProvider).FirstOrDefaultAsync();
            if (dbUser == null)
                throw new Exception("Kullanıcı Bulunamadı.");
            return dbUser;
        }

        public async Task<List<UserDTO>> GetUsers()
        {
            var dbUser = await context.Users.ProjectTo<UserDTO>(mapper.ConfigurationProvider).ToListAsync();
            return dbUser;
        }

        public async Task<UserDTO> UpdateUser(UserDTO User)
        {
            var dbUser = await context.Users.Where(c => c.Id == User.Id).FirstOrDefaultAsync();
            if (dbUser == null)
                throw new Exception("Kullanıcı Bulunamadığından Dolayı Güncelleme İşlemi Başarısız");
            mapper.Map(User, dbUser);

            int result = await context.SaveChangesAsync();
            return mapper.Map<UserDTO>(dbUser);
        }
    }
}
