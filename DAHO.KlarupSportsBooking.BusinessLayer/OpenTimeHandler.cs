using DAHO.KlarupSportsBooking.DateAccessLayer.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAHO.KlarupSportsBooking.BusinessLayer
{
    public class OpenTimeHandler : BaseHandler
    {
        public List<OpenTime> GetOpeningTimes()
        {
            return Model.OpenTimes.ToList();
        }

        public OpenTime GetCurrentTimes()
        {
            return Model.OpenTimes.LastOrDefault();
        }

        public List<DateTime> GetCurrentOpenCloseTimes()
        {
            OpenTime time = Model.OpenTimes.ToList().LastOrDefault();
            List<DateTime> list = new List<DateTime>() { time.WeekdayStart, time.WeekendEnd, time.WeekendStart, time.WeekendEnd };
            return list;
        }

        public List<Tuple<int,int>> DropdownSetterWeekday()
        {
            OpenTime time = Model.OpenTimes.ToList().LastOrDefault();
            List<Tuple<int, int>> list = new List<Tuple<int, int>>() { Tuple.Create(time.WeekdayStart.Hour, time.WeekdayStart.Minute) };
            while (time.WeekdayStart.Hour != time.WeekdayEnd.Hour || time.WeekdayStart.Minute != time.WeekdayEnd.Minute)
            {
                time.WeekdayStart = time.WeekdayStart.AddMinutes(30);
                list.Add(Tuple.Create(time.WeekdayStart.Hour, time.WeekdayStart.Minute));                
            } return list;
        }

        public List<Tuple<int, int>> DropdownSetterWeekend()
        {
            OpenTime time = Model.OpenTimes.ToList().LastOrDefault();
            List<Tuple<int, int>> list = new List<Tuple<int, int>>() { Tuple.Create(time.WeekendStart.Hour, time.WeekendStart.Minute) };
            while (time.WeekendStart.Hour != time.WeekendEnd.Hour || time.WeekendStart.Minute != time.WeekendEnd.Minute)
            {
                time.WeekendStart = time.WeekendStart.AddMinutes(30);
                list.Add(Tuple.Create(time.WeekendStart.Hour, time.WeekendStart.Minute));
            }
            return list;
        }

        public bool Add(OpenTime ot)
        {
            Model.OpenTimes.Add(ot);
            return SaveChanges();
        }
    }
}
