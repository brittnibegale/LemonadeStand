using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Cups: Item
    {
        int amountOfCups;
        string userInput;
        public Cups()
        {

        }
        public override int GetItemBoughtAmount()
        {
            Console.WriteLine("Each cup costs .10 cents. There are 6 cups in a pitcher. How many cups do you want to buy? Enter number values only.");
            userInput = Console.ReadLine();
            while (!int.TryParse(userInput, out amountOfCups))
            {
                Console.WriteLine("Invaild input. Please, enter a number.");
                userInput = Console.ReadLine();
            }
            return amountOfCups;

        }
    }
}
