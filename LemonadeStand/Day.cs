using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        List<int> days = new List<int>();
        int updatedDayCount;
        public Day()
        {
            GenerateDay(8);
        }
        //public void Day2()
        //{
        //    Weather day1 = new Weather();
        //    day1.DisplayWeather(1);
        //}

        public void GenerateDay(int day)
        {
            for(int i = 0; i < day; i++)
            {
                days.Add(new int());
            }

        }
        public void RemoveOneday(int day)
        {
            for (int i = 0; i < day; i++)
            {
                days.Remove(new int());
            }
            updatedDayCount = days.Count();
        }
    }
}
