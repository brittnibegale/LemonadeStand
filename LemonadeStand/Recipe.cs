using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        double removeLemon;
        double removeSugar;
        double removeIce;
        //int removeCups;
        string userInput;
        double amountOfItem;
        double amountOfRecipe;
        List<double> recipeList = new List<double>();

        public Recipe()
        {

        }

        public double LemonRecipe(double currentAmountOfLemons)
        {
            Console.WriteLine("How many lemons would you like in each pitcher? \n Enter how many lemons you would like in today's recipe.");
            userInput = Console.ReadLine();
            double possibleRemoveLemon = GetRemoveAmount(userInput);
            removeLemon = CheckForListAmount(currentAmountOfLemons, possibleRemoveLemon, .2);
            return removeLemon;
        }

        public double SugarRecipe(double currentAmountOfSugar)
        {
            Console.WriteLine("How many packets of sugar would you like in each pitcher? \n Enter how many sugar packets you would like in today's recipe.");
            userInput = Console.ReadLine();
            double possibleRemoveSugar = GetRemoveAmount(userInput);
            removeSugar = CheckForListAmount(currentAmountOfSugar, possibleRemoveSugar, .1);
            return removeSugar;
        }

        public double IceRecipe(double currentAmountOfIce)
        {
            Console.WriteLine("How many ice cubes would you like in each pitcher? \n Enter how many ice cubes you would like in today's recipe.");
            userInput = Console.ReadLine();
            double possibleRemovedIce = GetRemoveAmount(userInput);
            removeIce = CheckForListAmount(currentAmountOfIce, possibleRemovedIce, .1);
            return removeIce;
        }

        public double GetRemoveAmount(string amount)
        {
            while (!double.TryParse(userInput, out amountOfItem))
            {
                Console.WriteLine("Invaild input. Please, enter a number.");
                userInput = Console.ReadLine();
            }
            double removeAmount = amountOfItem;
            return removeAmount;
        }

        public double CheckForListAmount(double listAmount, double removeAmount, double costOfItem)//delete costofitem if i dont use this
        {
            while (true)
            {
                double newListAmount = listAmount - removeAmount;

                if (newListAmount >= 0)
                {
                    return removeAmount;
                }
                else
                {
                    Console.WriteLine("Sorry, you do not have enough of that item in your inventory to make a pitcher lemonade with that quantity. You have " + listAmount + " in your inventory. Please enter a number equal to less than " + listAmount);
                    userInput = Console.ReadLine();
                    removeAmount = GetRemoveAmount(userInput);
                    return removeAmount;
                }
            }
        }
            //CheckForMoney(listAmount, costOfItem);//make this method if we want to check cost of item
        public List<double> CreateRecipeList(double lemons, double sugar, double ice, double cups)
        {
            recipeList.Add(lemons);
            recipeList.Add(sugar);
            recipeList.Add(ice);
            recipeList.Add(cups);
            return recipeList;

        }

        public double AmountOfRecipesMade(double recipeBase, double pitchers)
        {
            amountOfRecipe = recipeBase * pitchers;
            return amountOfRecipe;
        }

     
           
     }
   }

