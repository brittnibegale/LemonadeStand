using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        List<double> days = new List<double>();
        public int updatedDayCount = 7;
        Weather today = new Weather();
        Customer todaysCustomers = new Customer();
        double weatherDay;
        double weatherEffectedCustomers;
        double todaysActualTotalCustomers;

        public Day()
        {
            GenerateDay(7);
        }

        private void GenerateDay(double day)
        {
            for(int i = 0; i < day; i++)
            {
                days.Add(new double());
            }

        }

        public int RemoveOneday()
        {
            for (int i = 0; i < 1 ; i++)
            {
                days.RemoveAt(0);
            }
            updatedDayCount = days.Count();
            return updatedDayCount;
        }

        public void GetWeather()
        {
            switch(updatedDayCount)
            {
                case 7:
                    weatherDay = today.DisplayWeather(1);
                    break;
                case 6:
                    weatherDay = today.DisplayWeather(2);
                    break;
                case 5:
                    weatherDay = today.DisplayWeather(3);
                    break;
                case 4:
                    weatherDay = today.DisplayWeather(4);
                    break;
                case 3:
                    weatherDay = today.DisplayWeather(5);
                    break;
                case 2:
                    weatherDay = today.DisplayWeather(6);
                    break;
                case 1:
                    weatherDay = today.DisplayWeather(7);
                    break;
               
                default:
                    Console.WriteLine("Sorry there are not 8 days in a week.");
                    Console.ReadLine();
                    break;
            }
        }

        public double SendRecipeToWeatherAndCustomer(List<double>recipe)
        {
            weatherEffectedCustomers = today.CompareWeatherToRecipe(recipe, weatherDay);
            todaysCustomers.CompareRecipeToCustomers(recipe, weatherEffectedCustomers);
            todaysActualTotalCustomers = todaysCustomers.SetAmountOfServedCustomers();
            return todaysActualTotalCustomers;
        }
    }
}
