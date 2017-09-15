using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        public Weather()
        {
        }
        public Weather(int day)
        {

        }
        

        public int DisplayWeather(int day)
        {
            switch (day)
            {
                case 1:
                    Console.WriteLine("Today's weather is going to be sunny and 85 degrees.");
                    Console.ReadLine();
                    return day;
                case 2:
                    Console.WriteLine("Today's weather is going to be cloudy and 40 degrees.... thank you Wisconsin for the crazy change in weather.");
                    Console.ReadLine();
                    return day;
                case 3:
                    Console.WriteLine("Today's weather is going to be rainy and 90 degrees.");
                    Console.ReadLine();
                    return day;
                case 4:
                    Console.WriteLine("Today's weather is going to be sunny and 55 degrees.");
                    Console.ReadLine();
                    return day;
                case 5:
                    Console.WriteLine("Today's weather is going to be cloudy and 70 degrees.");
                    Console.ReadLine();
                    return day;
                case 6:
                    Console.WriteLine("Today's weather is going to be rainy and 50 degrees.");
                    Console.ReadLine();
                    return day;
                case 7:
                    Console.WriteLine("Today's weather is going to be sunny and 75 degrees.");
                    Console.ReadLine();
                    return day;
                default:
                    break;
            }
            return day;
        }
    }
}
