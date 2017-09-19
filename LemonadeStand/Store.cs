using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        double boughtIce;
        double boughtLemons;
        double boughtSugar;
        double boughtCups;
        double costOfItems;
        Player player;
        public Store()
        {

        }

        public Store(Player player1)
        {
            this.player = player1;
        }

        public double BuyLemons(Player player)
        {
            Item lemonBoughtAmount = new Lemons();
            boughtLemons = lemonBoughtAmount.GetItemBoughtAmount();
            player.moneyBank.money = GetCost(boughtLemons, .2, player);
            return boughtLemons;
        }

        public double BuySugar(Player player)
        {
            Item sugarBoughtAmount = new Sugar();
            boughtSugar = sugarBoughtAmount.GetItemBoughtAmount();
            player.moneyBank.money = GetCost(boughtSugar, .1, player);
            return boughtSugar;
        }

        public double BuyIce(Player player)
        {
            Item iceBoughtAmount = new Ice();
            boughtIce = iceBoughtAmount.GetItemBoughtAmount();
            player.moneyBank.money = GetCost(boughtIce, .1, player);
            return boughtIce;
        }

        public double BuyCups(Player player)
        {
            Item cupBoughtAmount = new Cups();
            boughtCups = cupBoughtAmount.GetItemBoughtAmount();
            player.moneyBank.money = GetCost(boughtCups, .1, player);
            return boughtCups;
        }

        public double GetCost(double item, double cost, Player player)
        {
            costOfItems = item * cost;
            player.moneyBank.money = CheckForMoney(costOfItems, player.moneyBank.money);
            return player.moneyBank.money;
        }

        public double CheckForMoney(double costOfItems, double moneyBank)
        {
            moneyBank = moneyBank - costOfItems;
            while (moneyBank >= 0)
            {
                return moneyBank;
            }
            Console.WriteLine("Sorry, you do not have enough money. Would you like to continue the game? yes or no");
            string userInput = Console.ReadLine().ToLower();
            while (true)
            {
                if (userInput != "yes" || userInput != "no")
                {
                    Console.WriteLine("Please type yes or no for the game to continue or not.");
                    userInput = Console.ReadLine().ToLower();
                }
                WillGameContinue(userInput);
            }
        }

        public void WillGameContinue(string userInput)
        {
            if (userInput == "no")
            {
                Console.WriteLine("Thank you for playing Lemonade Stand.");
                Console.ReadLine();
            }
            else
            {
               
            }
        }


    }
}
