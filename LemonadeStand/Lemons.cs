using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Lemons : Item
    {
        string userInput;
        int amountOfLemons;
        public Lemons()
        {

        }
        public override int GetItemBoughtAmount()
        {
            Console.WriteLine("Each lemon costs .20 cents. How many lemons do you want to buy? Enter number values only.");
            userInput = Console.ReadLine();
            while (!int.TryParse(userInput, out amountOfLemons))
            {
                Console.WriteLine("Invaild input. Please, enter a number.");
                userInput = Console.ReadLine();
            }
            return amountOfLemons;

        }
    }
}
