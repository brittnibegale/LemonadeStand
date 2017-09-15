using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    
    public class Human: Player
    {
        Inventory inventoryList = new Inventory();
        Recipe recipe = new Recipe();
        int removeLemons;
        int removeSugar;
        int removeIce;
        int removeCups = 12;
        int countOfLemonList = 0;
        int countOfSugarList = 0;
        int countOfIceList = 0;
        int countOfCupList = 0;
        List<int> recipeList;
        public Human()
        {
            
            
        }
      
        public override List<int> SetRecipe()
        {
            removeLemons = recipe.LemonRecipe(countOfLemonList);
            removeSugar = recipe.SugarRecipe(countOfSugarList);
            removeIce = recipe.IceRecipe(countOfIceList);
            recipeList = recipe.CreateList(removeLemons, removeSugar, removeIce);
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

        public override void AddInventory(int amountOfCups, int amountOfIce, int amountOfLemons, int amountOfSugar)
        {
            inventoryList.AddLemonList(amountOfLemons);
            countOfLemonList = inventoryList.lemons.Count();
            inventoryList.AddSugarList(amountOfSugar);
            countOfSugarList = inventoryList.sugar.Count();
            inventoryList.AddIceList(amountOfIce);
            countOfIceList = inventoryList.ice.Count();
            inventoryList.AddCupList(amountOfCups);
            countOfCupList = inventoryList.cup.Count();
            inventoryList.DisplayInventory(countOfLemonList, countOfIceList, countOfSugarList, countOfCupList);
        }

        public void RemoveInventory(int removeCups, int removeIce, int removeLemons, int removeSugar)
        {
            inventoryList.RemoveLemons(removeLemons);
            inventoryList.RemoveSugar(removeSugar);
            inventoryList.RemoveIce(removeIce);
            inventoryList.RemoveCups(removeCups);
        }

        public override void DisplayInventoryFromInventory()
        {
            inventoryList.DisplayInventory(countOfLemonList, countOfIceList, countOfSugarList, countOfCupList);
        }

        public void CheckForInventory()
        {

        }
    }
}
