using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class TokenVol
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? ExpireAt { get; set; }

        [ForeignKey("Volunteer")]
        public int VolunteerId { get; set; }
        public virtual Volunteer Volunteer { get; set; }
    }
}
