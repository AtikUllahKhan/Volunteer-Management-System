using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    internal class TokenVolRepo: Repo, IRepo<TokenVol,string,TokenVol>
    {
        public TokenVol Create(TokenVol obj)
        {
            db.TokenVols.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public TokenVol Get(string id)
        {
            return db.TokenVols.FirstOrDefault(t => t.Key.Equals(id));

        }

        public List<TokenVol> Get()
        {
            throw new NotImplementedException();
        }

        public TokenVol Update(TokenVol obj)
        {
            var ex = Get(obj.Key);
            db.Entry(ex).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return ex;
        }
    }
}
