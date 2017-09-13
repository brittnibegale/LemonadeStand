using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public Inventory()
        {
        }

        public void CountIngredients(double moneyBank)
        {
            Store visit = new Store();
            visit.BuyIngredients(moneyBank);
        }
    }
}
