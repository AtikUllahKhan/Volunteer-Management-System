using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdminService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Admin, AdminDTO>();
                cfg.CreateMap<AdminDTO, Admin>();
                
                // foreign key purpose
                cfg.CreateMap<Admin, AdminEventDTO>();
                cfg.CreateMap<Admin, AdminVolunteerDTO>();
                cfg.CreateMap<Event, EventDTO>();
                cfg.CreateMap<Volunteer, VolunteerDTO>();
                

            });
            return new Mapper(config);
        }

        public static List<AdminDTO> Get()
        {
            var repo = DataAccessFactory.AdminData();
            var data = repo.Get();
            return GetMapper().Map<List<AdminDTO>>(data);
        }

        public static AdminDTO Get(int id)
        {
            var repo = DataAccessFactory.AdminData();
            var data = repo.Get(id);
            return GetMapper().Map<AdminDTO>(data);
        }

        public static void Create(AdminDTO a)
        {
            var repo = DataAccessFactory.AdminData();

            var obj = GetMapper().Map<Admin>(a);
            
            repo.Create(obj);
        }
        public static void Update(int id, AdminDTO a)
        {

            var repo = DataAccessFactory.AdminData();
            var adminToUpdate = GetMapper().Map<Admin>(a);
            adminToUpdate.Id = id;
            repo.Update(adminToUpdate);
        }

        public static void Delete(int id)
        {
            var repo = DataAccessFactory.AdminData();
            repo.Delete(id);
        }

        public static AdminEventDTO GetwithEvents(int id)
        {
            var repo = DataAccessFactory.AdminData();
            var data = repo.Get(id);
            return GetMapper().Map<AdminEventDTO>(data);
        }

        public static AdminVolunteerDTO GetwithVolunteers(int id)
        {
            var repo = DataAccessFactory.AdminData();
            var data = repo.Get(id);
            return GetMapper().Map<AdminVolunteerDTO>(data);
        }

    }
}
