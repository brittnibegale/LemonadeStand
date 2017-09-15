using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public abstract class Player 
    {
        public string name;
        public Wallet moneyBank;
        public Inventory inventoryList;
        public Player()
        {
            SetPlayersName();
            GetPlayersMoney();
            moneyBank = new Wallet();
        }
        public abstract List<int> SetRecipe();

        public abstract void SetPlayersName();

        public abstract void GetPlayersMoney();


        public abstract void AddInventory(int amountOfCups, int amountOfIce, int amountOfLemons, int amountOfSugar);

        public abstract void DisplayInventoryFromInventory();

    }
}
