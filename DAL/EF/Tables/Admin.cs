using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual List<Volunteer> Volunteers { get; set; }
        public virtual List<Event> Events { get; set; }

        public Admin()
        {
            Volunteers = new List<Volunteer>();
            Events = new List<Event>();
        }

        
    }
}
