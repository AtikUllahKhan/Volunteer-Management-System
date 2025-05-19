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
    public class EventService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Event, EventDTO>();
                cfg.CreateMap<EventDTO, Event>();
                
                // foreign key purpose
                cfg.CreateMap<Event, EventAdminDTO>();
                cfg.CreateMap<Event, EventVolunteerDTO>();

                cfg.CreateMap<Admin, AdminDTO>();
                cfg.CreateMap<Volunteer, VolunteerDTO>();
                

            });
            return new Mapper(config);
        }
        public static List<EventDTO> Get()
        {
            var repo = DataAccessFactory.EventData();
            var data = repo.Get();
            return GetMapper().Map<List<EventDTO>>(data);
        }

        public static EventDTO Get(int id)
        {
            var repo = DataAccessFactory.EventData();
            var data = repo.Get(id);
            return GetMapper().Map<EventDTO>(data);
        }

        public static void Create(EventDTO e)
        {
            var repo = DataAccessFactory.EventData();
            var obj = GetMapper().Map<Event>(e);
            repo.Create(obj);
        }

        public static void Update(int id, EventDTO e)
        {
            var repo = DataAccessFactory.EventData();
            var eventToUpdate = GetMapper().Map<Event>(e);
            eventToUpdate.Id = id;
            repo.Update(eventToUpdate);
        }

        public static void Delete(int id)
        {
            var repo = DataAccessFactory.EventData();
            repo.Delete(id);
        }

        public static EventAdminDTO GetwithAdmin(int id)
        {

            var repo = DataAccessFactory.EventData();
            var data = repo.Get(id);
            return GetMapper().Map<EventAdminDTO>(data);
        }

        public static EventVolunteerDTO GetwithVolunteer(int id)
        {

            var repo = DataAccessFactory.EventData();
            var data = repo.Get(id);
            return GetMapper().Map<EventVolunteerDTO>(data);
        }
    }
}
