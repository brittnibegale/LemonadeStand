using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Ice : Item
    {
        int amountOfIce;
        string userInput;

        public Ice()
        {

        }

        public override int GetItemBoughtAmount()
        {
            Console.WriteLine("Each ice cube costs .10 cents. How many ice cubes do you want to buy? Enter number values only.");
            userInput = Console.ReadLine(); 
            while (!int.TryParse(userInput, out amountOfIce))
            {
                Console.WriteLine("Invaild input. Please, enter a number.");
                userInput = Console.ReadLine();
            }
            return amountOfIce;
        }
    }
}
