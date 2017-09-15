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
        List<int> recipeList = new List<int>();

        public Recipe()
        {

        }

        public int LemonRecipe(int currentAmountOfLemons)
        {
            Console.WriteLine("How many lemons would you like in each pitcher? Remember there are going to be 5 pitchers made each day. \n Enter how many lemons you would like in today's recipe.");
            userInput = Console.ReadLine();
            int possibleRemoveLemon = GetRemoveAmount(userInput);
            removeLemon = CheckForListAmount(currentAmountOfLemons, possibleRemoveLemon, .2);
            return removeLemon;
        }

        public int SugarRecipe(int currentAmountOfSugar)
        {
            Console.WriteLine("How many packets of sugar would you like in each pitcher? Remember there are going to be 5 pitchers made each day. \n Enter how many sugar packets you would like in today's recipe.");
            userInput = Console.ReadLine();
            int possibleRemoveSugar = GetRemoveAmount(userInput);
            removeSugar = CheckForListAmount(currentAmountOfSugar, possibleRemoveSugar, .1);
            return removeSugar;
        }

        public int IceRecipe(int currentAmountOfIce)
        {
            Console.WriteLine("How many ice cubes would you like in each pitcher? Remember there are going to be 5 pitchers made each day. \n Enter how many ice cubes you would like in today's recipe.");
            userInput = Console.ReadLine();
            int possibleRemovedIce = GetRemoveAmount(userInput);
            removeIce = CheckForListAmount(currentAmountOfIce, possibleRemovedIce, .1);
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

        public int CheckForListAmount(int listAmount, int removeAmount, double costOfItem)//delete costofitem if i dont use this
        {
            while (true)
            {
                int newListAmount = listAmount - removeAmount;

                if (newListAmount >= 0)
                {
                    return removeAmount;
                }
                else
                {
                    Console.WriteLine("Sorry, you do not have enough of that item in your inventory to make 5 pitchers of lemonade with that quantity. You have " + listAmount + " in your inventory. Please enter a number equal to less than " + listAmount / 5);
                    userInput = Console.ReadLine();
                    removeAmount = GetRemoveAmount(userInput);
                    return removeAmount;
                }
            }
        }
            //CheckForMoney(listAmount, costOfItem);//make this method if we want to check cost of item
            public List<int> CreateList(int lemons, int sugar, int ice)
        {
            recipeList.Add(lemons);
            recipeList.Add(sugar);
            recipeList.Add(ice);
            return recipeList;

        }
           
        }
      
    }

