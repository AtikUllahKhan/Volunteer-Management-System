using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class Token
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? ExpireAt { get; set; }

        [ForeignKey("Admin")]
        public int AdminId {  get; set; }
        public virtual Admin Admin { get; set; }
    }
}
