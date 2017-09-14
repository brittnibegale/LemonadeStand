using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Sugar : Item
    {
        string userInput;
        int amountOfSugar;
        public Sugar()
        {

        }
        public override int GetItemBoughtAmount()
        {
            Console.WriteLine("Each sugar packet costs .10 cents. How many sugar packets do you want to buy? Enter number values only.");
            userInput = Console.ReadLine();
            while (!int.TryParse(userInput, out amountOfSugar))
            {
                Console.WriteLine("Invaild input. Please, enter a number.");
                userInput = Console.ReadLine();
            }
            return amountOfSugar;

        }
    }
}
