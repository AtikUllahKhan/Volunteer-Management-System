using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AdminEventDTO : AdminDTO
    {
        public List<EventDTO> Events { get; set; }
        

        // jokhon e kono collection of data thakbe take contructor a initiate korte hobe
        public AdminEventDTO()
        {
            
            Events = new List<EventDTO>();
            
        }

    }
}
