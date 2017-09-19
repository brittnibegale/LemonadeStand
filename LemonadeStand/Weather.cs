using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        double effectedCustomers;

        public Weather()
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

        public double CompareWeatherToRecipe(List<double> recipe, double weatherDay)
        {
            if (weatherDay == 1 || weatherDay == 3 || weatherDay == 7)
            {
                if (recipe[2] >= 5)
                {
                    effectedCustomers = 0;
                }
                else if (recipe[2] < 5 && recipe[2] >= 3)
                {
                    effectedCustomers = 5;
                }
                else if (recipe[2] < 3)
                {
                    effectedCustomers = 7;
                }
            }
            else if (weatherDay == 4 || weatherDay == 5)
            {
                if (recipe[2] >= 5)
                {
                    effectedCustomers = 5;
                }
                else if (recipe[2] < 5 && recipe[2] >= 3)
                {
                    effectedCustomers = 0;
                }
                else if (recipe[2] < 3)
                {
                    effectedCustomers = 7;
                }
            }
            else if (weatherDay == 6 || weatherDay == 2)
            {
                if (recipe[2] >= 5)
                {
                    effectedCustomers = 7;
                }
                else if (recipe[2] < 5 && recipe[2] >= 3)
                {
                    effectedCustomers = 5;
                }
                else if (recipe[2] < 3)
                {
                    effectedCustomers = 0;
                }
            }
            return effectedCustomers;
        }
    }
}
