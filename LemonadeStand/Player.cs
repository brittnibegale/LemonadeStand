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
        public Inventory inventoryList = new Inventory();
        public Player()
        {
            SetPlayersName();
            GetPlayersMoney();
            moneyBank = new Wallet();
        }

        public abstract List<double> SetRecipe();

        public abstract void SetPlayersName();

        public abstract void GetPlayersMoney();

        public abstract void AddInventory(double amountOfCups, double amountOfIce, double amountOfLemons, double amountOfSugar);

        public abstract void RemoveInventory();

        public abstract void DisplayInventoryFromInventory();

        public abstract double SetCostPerCup();

        public abstract double CheckForPitcherAmount();

        public abstract void CalculateInventoryLoss(double pitchers);

    }
}
