using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AdminVolunteerDTO : AdminDTO
    {
       
        public List<VolunteerDTO> Volunteers { get; set; }

        // jokhon e kono collection of data thakbe take contructor a initiate korte hobe
        public AdminVolunteerDTO()
        {

            Volunteers = new List<VolunteerDTO>();
        }
    }
}
