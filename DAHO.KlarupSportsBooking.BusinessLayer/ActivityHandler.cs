using DAHO.KlarupSportsBooking.DateAccessLayer.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHO.KlarupSportsBooking.BusinessLayer
{
    public class ActivityHandler : BaseHandler
    {
        public List<Activity> GetAllActivities()
        {
            return Model.Activities.ToList();
        }
    }
}
