using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Admin, AdminDTO>();
                cfg.CreateMap<AdminDTO, Admin>();
                cfg.CreateMap<Token, TokenDTO>();

                cfg.CreateMap<Volunteer, VolunteerDTO>();
                cfg.CreateMap<VolunteerDTO, Volunteer>();
                cfg.CreateMap<TokenVol, TokenVolDTO>();

            });
            return new Mapper(config);
        }

        public static TokenDTO Authenticate(string uname, string pass)
        {
            var auth = DataAccessFactory.AuthData().Authenticate(uname, pass);
            if (auth != null)
            {
                var token = new Token();
                token.CreateAt= DateTime.Now;
                token.AdminId = auth.Id;
                token.Key= Guid.NewGuid().ToString();
                var tk= DataAccessFactory.TokenData().Create(token);
                return GetMapper().Map<TokenDTO>(tk);
            }

            return null;
        }
        public static TokenVolDTO Authenticate1(string name, string contact)
        {
            var auth1 = DataAccessFactory.AuthVolunteerData().Authenticate1(name, contact);
            if (auth1 != null)
            {
                var token = new TokenVol();
                token.CreateAt = DateTime.Now;
                token.VolunteerId = auth1.Id;
                token.Key = Guid.NewGuid().ToString();
                var tk = DataAccessFactory.TokenVolunteerData().Create(token);
                return GetMapper().Map<TokenVolDTO>(tk);
            }

            return null;
        }
        public static bool IsTokenValid(string key)
        {
            var token = DataAccessFactory.TokenData().Get(key);
            if (token != null && token.ExpireAt == null)
            {
                return true;

            }
            return false;
        }

        public static bool IsTokenValid1(string key)
        {
            var token = DataAccessFactory.TokenVolunteerData().Get(key);
            if (token != null && token.ExpireAt == null)
            {
                return true;

            }
            return false;
        }

        public static bool Logout (string key)
        {
            var token = DataAccessFactory.TokenData().Get(key);
            if (token != null )
            {
                token.ExpireAt = DateTime.Now;
                DataAccessFactory.TokenData().Update(token);
                return true;

            }
            return false;
        }

    }
}
