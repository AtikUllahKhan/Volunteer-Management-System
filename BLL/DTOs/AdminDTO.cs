using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
     public class AdminDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        /*public List<EventDTO> Events { get; set; }
        public AdminDTO()
        {
            Events = new List<EventDTO>();
            //Volunteers = new List<VolunteerDTO>();
        }*/
    }
}
