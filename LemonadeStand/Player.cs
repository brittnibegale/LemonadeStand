using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player : IRecipe
    {
        string name;
        double moneyBank = 20.00;
        public Player()
        {
            
        }
        public void SetRecipe()
        {

        }
        public void SetPlayersName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }

        public void GetIngredients()
        {
            Inventory ingredients = new Inventory();
            ingredients.CountIngredients(moneyBank);
        }
    }
}
