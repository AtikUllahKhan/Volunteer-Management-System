using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class VolunteerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Skill { get; set; }
        public string Availability { get; set; }

        public int EventId { get; set; }

        
        public int AdminId { get; set; }
    }
}
