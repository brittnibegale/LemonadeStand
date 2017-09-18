using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    
    public class Human: Player
    {
        Recipe recipe = new Recipe();
        double lemonsRecipeCount;
        double sugarRecipeCount;
        double iceRecipeCount;
        double cupsRecipeCount;
        double removeLemons;
        double removeSugar;
        double removeIce;
        double removeCups;
        double countOfLemonList = 0;
        double countOfSugarList = 0;
        double countOfIceList = 0;
        double countOfCupList = 0;
        double cost;
        List<double> recipeList;
        public Human()
        {
            
            
        }
      
        public override List<double> SetRecipe()
        {
            lemonsRecipeCount = recipe.LemonRecipe(countOfLemonList);
            sugarRecipeCount = recipe.SugarRecipe(countOfSugarList);
            iceRecipeCount = recipe.IceRecipe(countOfIceList);
            cupsRecipeCount = 6;
            recipeList = recipe.CreateRecipeList(lemonsRecipeCount, sugarRecipeCount, iceRecipeCount, cupsRecipeCount);

            return recipeList;
        }
        public override void SetPlayersName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }
        public override void GetPlayersMoney()
        {
            Wallet moneyBank = new Wallet();
        }

        public override void AddInventory(double amountOfCups, double amountOfIce, double amountOfLemons, double amountOfSugar)
        {
            inventoryList.AddLemonList(amountOfLemons);
            countOfLemonList = inventoryList.lemons.Count();
            inventoryList.AddSugarList(amountOfSugar);
            countOfSugarList = inventoryList.sugar.Count();
            inventoryList.AddIceList(amountOfIce);
            countOfIceList = inventoryList.ice.Count();
            inventoryList.AddCupList(amountOfCups);
            countOfCupList = inventoryList.cup.Count();
            inventoryList.DisplayInventory();
        }

        public override void RemoveInventory()
        {
            inventoryList.RemoveLemons(removeLemons);
            countOfLemonList = inventoryList.lemons.Count();
            inventoryList.RemoveSugar(removeSugar);
            countOfSugarList = inventoryList.sugar.Count();
            inventoryList.RemoveIce(removeIce);
            countOfIceList = inventoryList.ice.Count();
            inventoryList.RemoveCups(removeCups);
            countOfCupList = inventoryList.cup.Count();
        }

        public override double CheckForPitcherAmount()
        {
            double pitchers = inventoryList.CheckCups(countOfCupList);
            pitchers = inventoryList.CheckIceSugarLemons(recipeList[2], countOfIceList, pitchers);
            pitchers = inventoryList.CheckIceSugarLemons(recipeList[1], countOfSugarList, pitchers);
            pitchers = inventoryList.CheckIceSugarLemons(recipeList[0], countOfLemonList, pitchers);
            return pitchers;
        }

        public override void DisplayInventoryFromInventory()
        {
            inventoryList.DisplayInventory();
        }



        public override double SetCostPerCup()
        {
            Console.WriteLine("What would you like to set the cost of a cup. It has to be below 1.00. Please enter only numbers and decimal points ex: .50 or 1.00");
            string userInput = Console.ReadLine();
            while(!double.TryParse(userInput, out cost))
            {
                Console.WriteLine("Invalid input. Please, enter a number.");
                userInput = Console.ReadLine();
            }

            return cost; 
        }

        public override void CalculateInventoryLoss(double pitchers)
        {
            removeCups = recipe.AmountOfRecipesMade(recipeList[3], pitchers);
            removeIce = recipe.AmountOfRecipesMade(recipeList[2], pitchers);
            removeLemons = recipe.AmountOfRecipesMade(recipeList[0], pitchers);
            removeSugar = recipe.AmountOfRecipesMade(recipeList[1], pitchers);
            RemoveInventory();

        }
    }
}
