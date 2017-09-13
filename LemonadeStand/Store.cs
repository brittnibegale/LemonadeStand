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
        public void BuyLemons(Player player)
        {
            Item lemonAmount = new Lemons();
            boughtLemons = lemonAmount.GetItemAmount();
            player.moneyBank = GetCost(boughtLemons, .2);
            LemonList(boughtLemons);

        }

        public void BuySugar(Player player)
        {
            Item sugarAmount = new Sugar();
            boughtSugar = sugarAmount.GetItemAmount();
            player.moneyBank = GetCost(boughtSugar, .1);
            SugarList(boughtSugar);
        }

        public void BuyIce(Player player)
        {
            Item iceAmount = new Ice();
            boughtIce = iceAmount.GetItemAmount();
            player.moneyBank = GetCost(boughtIce, .1);
            IceList(boughtIce);
        }

        public void BuyCups(Player player)
        {
            Item cupAmount = new Cups();
            boughtCups = cupAmount.GetItemAmount();
            player.moneyBank = GetCost(boughtCups, .1);
            CupList(boughtCups);
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
        public double GetCost(int item, double cost)
        {
            costOfItems = item * cost;
            player.moneyBank = CheckForMoney(costOfItems, player.moneyBank);
            return player.moneyBank;
        }

        public void LemonList(int item)
        {
            List<Lemons> lemon = new List<Lemons>();
            for(int i = 0; i < item; i++)
            {
                lemon.Add(new Lemons());
            }
        }

        public void SugarList(int item)
        {
            List<Sugar> sugar = new List<Sugar>();
            for (int i = 0; i < item; i++)
            {
                sugar.Add(new Sugar());
            }
        }
        public void IceList(int item)
        {
            List<Ice> ice = new List<Ice>();
            for (int i = 0; i < item; i++)
            {
                ice.Add(new Ice());
            }
        }
        public void CupList(int item)
        {
            List<Cups> cup = new List<Cups>();
            for (int i = 0; i < item; i++)
            {
                cup.Add(new Cups());
            }
        }
    }
}
