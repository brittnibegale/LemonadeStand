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

        public override void GetInventory()
        {
            Inventory inventory = new Inventory();
        }
    }
}
