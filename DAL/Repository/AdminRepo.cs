using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    internal class AdminRepo : Repo, IRepo<Admin, int, Admin>,IAuth
    {
        public Admin Authenticate(string uname, string pass)
        {
            return db.Admins.FirstOrDefault(x => x.Username.Equals(uname) && x.Password.Equals(pass));
        }

        public Admin Create(Admin obj)
        {
            db.Admins.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public void Delete(int id)
        {
            var ex =Get(id);
            db.Admins.Remove(ex);
            db.SaveChanges();
        }

        public Admin Get(int id)
        {
            return db.Admins.FirstOrDefault(x=>x.Id.Equals(id));
        }

        public List<Admin> Get()
        {
            return db.Admins.ToList();
        }

        public Admin Update(Admin obj)
        {
            var ex = Get(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return ex;
        }
    }
}
