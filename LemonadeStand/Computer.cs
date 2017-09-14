using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Computer: Player
    {
        public Computer()
        {

        }
        public override void SetRecipe()
        {

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
