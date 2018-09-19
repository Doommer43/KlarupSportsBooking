using DAHO.KlarupSportsBooking.DateAccessLayer.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHO.KlarupSportsBooking.BusinessLayer
{
    public class UnionHandler : BaseHandler
    {
        /// <summary>
        /// Return the user, if any, matches the login data.
        /// </summary>
        /// <param name="name">User typed name</param>
        /// <param name="pass">User typed password</param>
        /// <returns></returns>
        public Union Login(string name, string pass)
        {
            if (name.Any(a=> a == '@'))
            {
                return Model.Unions.Where(u => u.Email == name && u.Password == pass).FirstOrDefault();
            }
            throw new ArgumentException("Der er ikke angivet et korrekt brugernavn");
        }
    }
}
