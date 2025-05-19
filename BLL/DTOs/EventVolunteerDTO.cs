using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class EventVolunteerDTO :EventDTO
    {
        public List<VolunteerDTO> Volunteers { get; set; }

        // jokhon e kono collection of data thakbe take contructor a initiate korte hobe
        public EventVolunteerDTO()
        {
            Volunteers = new List<VolunteerDTO>();
        }
    }
}
