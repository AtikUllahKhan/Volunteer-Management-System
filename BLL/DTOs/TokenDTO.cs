using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TokenDTO
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? ExpireAt { get; set; }

        public int AdminId { get; set; }

    }
}
