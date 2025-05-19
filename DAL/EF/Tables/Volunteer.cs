using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class Volunteer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact {  get; set; }
        public string Skill {  get; set; }
        public string Availability {  get; set; }

        [ForeignKey("Event")]
        public int? EventId { get; set; }
        public virtual Event Event { get; set; }

        [ForeignKey("Admin")]
        public int AdminId { get; set; }
        public virtual Admin Admin { get; set; }

        
       
    }
}
