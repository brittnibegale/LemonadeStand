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
        public Store()
        {

        }
        public void BuyIngredients(double moneyBank)
        { //find a way to not be able to buy more when out of money
            Item lemonAmount = new Lemons();
            boughtLemons = lemonAmount.GetItemAmount();
            GetCost(boughtLemons, .2, moneyBank);
            Item sugarAmount = new Sugar();
            boughtSugar = sugarAmount.GetItemAmount();
            GetCost(boughtSugar, .1, moneyBank);
            Item iceAmount = new Ice();
            boughtIce = iceAmount.GetItemAmount();
            GetCost(boughtIce, .1, moneyBank);
            Item cupAmount = new Cups();
            boughtCups = cupAmount.GetItemAmount();
            GetCost(boughtCups, .1, moneyBank);
            
            // getting the amounts of ice how to store this.....
        }

        public void CheckForMoney(double costOfItems, double moneyBank)
        {
            //while loop for positive money account
        }
        public void GetCost(int item, double cost, double moneyBank)
        {
            costOfItems = item * cost;
            CheckForMoney(costOfItems, moneyBank);
        }
    }
}
