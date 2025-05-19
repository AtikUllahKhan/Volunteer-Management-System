using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    internal class VolunteerRepo : Repo, IRepo<Volunteer, int, Volunteer>, IVolunteerFeatures, IAuthVolunteer
    {
        public Volunteer Create(Volunteer obj)
        {
            db.Volunteers.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public void Delete(int id)
        {
            var ex =Get (id);
            db.Volunteers.Remove(ex);
            db.SaveChanges();
        }

        public Volunteer Get(int id)
        {
            return db.Volunteers.Find (id);
        }

        public List<Volunteer> Get()
        {
            return db.Volunteers.ToList ();
        }

        public Volunteer Update(Volunteer obj)
        {
            var ex = Get (obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return obj;
        }

        //Search by Feature
        public List<Volunteer> SearchByName(string name)
        {
            return db.Volunteers.Where(p=>p.Name.Contains(name)).ToList();
        }
        
        public List<Volunteer> SearchByAvailability(string availability)
        {
            return db.Volunteers.Where(a=>a.Availability.Contains(availability)).ToList();
        }

        public Volunteer Authenticate1(string name, string contact)
        {
            return db.Volunteers.FirstOrDefault(x => x.Name.Equals(name) && x.Contact.Equals(contact));
        }
    }
}
