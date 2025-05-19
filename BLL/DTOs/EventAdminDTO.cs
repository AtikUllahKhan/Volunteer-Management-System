using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class EventAdminDTO : EventDTO
    {
        public AdminDTO Admin { get; set; }
        
    }
}
