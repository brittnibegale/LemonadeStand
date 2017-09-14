using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        int boughtIce;
        int boughtLemons;
        int boughtSugar;
        int boughtCups;
        double costOfItems;
        Player player;
        public Store()
        {

        }
        public Store(Player player1)
        {
            this.player = player1;
        }
        public int BuyLemons(Player player)
        {
            Item lemonBoughtAmount = new Lemons();
            boughtLemons = lemonBoughtAmount.GetItemBoughtAmount();
            player.moneyBank.money = GetCost(boughtLemons, .2, player);
            return boughtLemons;
        }

        public int BuySugar(Player player)
        {
            Item sugarBoughtAmount = new Sugar();
            boughtSugar = sugarBoughtAmount.GetItemBoughtAmount();
            player.moneyBank.money = GetCost(boughtSugar, .1, player);
            return boughtSugar;
        }

        public int BuyIce(Player player)
        {
            Item iceBoughtAmount = new Ice();
            boughtIce = iceBoughtAmount.GetItemBoughtAmount();
            player.moneyBank.money = GetCost(boughtIce, .1,player);
            return boughtIce;
        }

        public int BuyCups(Player player)
        {
            Item cupBoughtAmount = new Cups();
            boughtCups = cupBoughtAmount.GetItemBoughtAmount();
            player.moneyBank.money = GetCost(boughtCups, .1, player);
            return boughtCups;
        }

        public double CheckForMoney(double costOfItems, double moneyBank)
        {
            moneyBank = moneyBank - costOfItems;
            while (moneyBank > 0)
            {
                return moneyBank;
            }
            Console.WriteLine("Sorry, you do not have enough money.");
            Console.ReadLine();
                return moneyBank;
            //make it so they can re-enter how much they want to buy or just move on to the next item.
        }
        public double GetCost(int item, double cost, Player player)
        {
            costOfItems = item * cost;
            player.moneyBank.money = CheckForMoney(costOfItems, player.moneyBank.money);
            return player.moneyBank.money;
        }

       
    }
}
