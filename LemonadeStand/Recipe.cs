using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        int removeLemon;
        int removeSugar;
        int removeIce;
        //int removeCups;
        string userInput;
        int amountOfItem;
        public Recipe()
        {

        }

        public int LemonRecipe()
        {
            Console.WriteLine("How many lemons would you like in each pitcher? Remember there are going to be 5 pitchers made each day. \n Enter how many lemons you would like in today's recipe.");
            userInput = Console.ReadLine();
            removeLemon = GetRemoveAmount(userInput);
            return removeLemon;
        }

        public int SugarRecipe()
        {
            Console.WriteLine("How many packets of sugar would you like in each pitcher? Remember there are going to be 5 pitchers made each day. \n Enter how many sugar packets you would like in today's recipe.");
            userInput = Console.ReadLine();
            removeSugar = GetRemoveAmount(userInput);
            return removeSugar;
        }

        public int IceRecipe()
        {
            Console.WriteLine("How many ice cubes would you like in each pitcher? Remember there are going to be 5 pitchers made each day. \n Enter how many ice cubes you would like in today's recipe.");
            userInput = Console.ReadLine();
            removeIce = GetRemoveAmount(userInput);
            return removeIce;
        }

        public int GetRemoveAmount(string amount)
        {
            while (!int.TryParse(userInput, out amountOfItem))
            {
                Console.WriteLine("Invaild input. Please, enter a number.");
                userInput = Console.ReadLine();
            }
            int removeAmount = amountOfItem * 5;
            return removeAmount;
        }
      
    }
}
