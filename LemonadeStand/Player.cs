using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public abstract class Player : IRecipe
    {
        public string name;
        public double moneyBank = 20.00;
        public Player()
        {
            SetPlayersName();
        }
        public abstract void SetRecipe();

        public abstract void SetPlayersName();


        public abstract void GetInventory();
       
    }
}
