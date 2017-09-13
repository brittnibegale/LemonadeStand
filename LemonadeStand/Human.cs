using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Human: Player
    {
        public Human()
        {
        }
        
        //public double MoneyBank
        //{
        //    get
        //    {
        //        return moneyBank;
        //    }
        //    set
        //    {
        //        moneyBank = value;
        //    }
        //}

      
        public override void SetRecipe()
        {

        }
        public override void SetPlayersName()
        {

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
           
        }

        public override void GetInventory()
        {
            Inventory inventory = new Inventory();
        }
    }
}
