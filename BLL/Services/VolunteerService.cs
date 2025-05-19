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
    public class VolunteerService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Volunteer, VolunteerDTO>();
                cfg.CreateMap<VolunteerDTO, Volunteer>();
                
                // foreign key purpose
                cfg.CreateMap<Volunteer, VolunteerAdminDTO>();
                cfg.CreateMap<Volunteer, VolunteerEventDTO>();

                cfg.CreateMap<Admin, AdminDTO>();
                cfg.CreateMap<Event, EventDTO>();
                

            });
            return new Mapper(config);
        }

        public static List<VolunteerDTO> Get()
        {
            var repo = DataAccessFactory.VolunteerData();
            var data = repo.Get();
            return GetMapper().Map<List<VolunteerDTO>>(data);
        }

        public static VolunteerDTO Get(int id)
        {
            var repo = DataAccessFactory.VolunteerData();
            var data = repo.Get(id);
            return GetMapper().Map<VolunteerDTO>(data);
        }

        public static void Create(VolunteerDTO v)
        {
            var repo = DataAccessFactory.VolunteerData();
            var obj = GetMapper().Map<Volunteer>(v);
            repo.Create(obj);
        }

        public static void Update(int id ,VolunteerDTO v)
        {
            var repo = DataAccessFactory.VolunteerData();
            var volunteerToUpdate = GetMapper().Map<Volunteer>(v);
            volunteerToUpdate.Id = id;
            repo.Update(volunteerToUpdate);
        }

        public static void Delete(int id)
        {
            var repo = DataAccessFactory.VolunteerData();
            repo.Delete(id);
        }

        // Search by foreign Key
        public static VolunteerAdminDTO GetwithAdmin(int id)
        {

            var repo = DataAccessFactory.VolunteerData();
            var data = repo.Get(id);
            return GetMapper().Map<VolunteerAdminDTO>(data);
        }

        public static VolunteerEventDTO GetwithEvent(int id)
        {

            var repo = DataAccessFactory.VolunteerData();
            var data = repo.Get(id);
            return GetMapper().Map<VolunteerEventDTO>(data);
        }

        // Search By Feature
        public static List<VolunteerDTO> SearchByName(string name)
        {
            var repo = DataAccessFactory.VolunteerFeatures();
            var data = repo.SearchByName(name);
            return GetMapper().Map<List<VolunteerDTO>>(data);
        }
        
        public static List<VolunteerDTO> SearchByAvailability(string availability)
        {
            var repo = DataAccessFactory.VolunteerFeatures();
            var data = repo.SearchByAvailability(availability);
            return GetMapper().Map<List<VolunteerDTO>>(data);
        }

        





    }
}
