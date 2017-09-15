using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Computer: Player
    {
        List<int> recipe;
        public Computer()
        {

        }
        public override List<int> SetRecipe()
        {
            return recipe;
        }
        public override void SetPlayersName()
        {
            name = "Computer";
        }

        public override void AddInventory(int amountOfCups, int amountOfIce, int amountOfLemons, int amountOfSugar)
        {
            Inventory inventory = new Inventory();
        }

        public override void GetPlayersMoney()
        {
            Wallet money = new Wallet(); 
        }
        public override void DisplayInventoryFromInventory()
        {

        }
    }
}
