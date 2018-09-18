using DAHO.KlarupSportsBooking.DateAccessLayer.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHO.KlarupSportsBooking.BusinessLayer
{
    public class AdminHandler : BaseHandler
    {
        public Admin Login(string user, string pass)
        {
            return Model.Admins.Where(a => a.Email == user && a.Password == pass).FirstOrDefault();
        }
    }
}
