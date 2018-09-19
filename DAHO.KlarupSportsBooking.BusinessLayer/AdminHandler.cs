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
            if(user.Any(a=> a == '@'))
            {
                return Model.Admins.Where(a => a.Email == user && a.Password == pass).FirstOrDefault();
            }
            throw new ArgumentException("Der er ikke angivet et korrekt brugernavn");
        }
    }
}
