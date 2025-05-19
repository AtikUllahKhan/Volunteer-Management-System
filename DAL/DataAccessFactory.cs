using DAL.EF.Tables;
using DAL.Interfaces;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Volunteer, int, Volunteer> VolunteerData()
        {
            return new VolunteerRepo();
        }

        public static IRepo<Admin, int, Admin> AdminData()
        {
            return new AdminRepo();
        }

        public static IRepo<Event, int, Event> EventData()
        {
            return new EventRepo();
        }
        public static IVolunteerFeatures VolunteerFeatures()
        {
            return new VolunteerRepo();
        }

        public static IVolunteerFeatures VolunteerAssign()
        {
            return new VolunteerRepo();
        }
        public static IAuth AuthData()
        {
            return new AdminRepo();
        }

        public static IRepo<Token, string, Token> TokenData()
        {
            return new TokenRepo();
        }

        public static IAuthVolunteer AuthVolunteerData()
        {
            return new VolunteerRepo();
        }

        public static IRepo<TokenVol, string, TokenVol> TokenVolunteerData()
        {
            return new TokenVolRepo();
        }
    }
}
