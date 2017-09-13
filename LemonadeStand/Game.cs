using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        public Game()
        {

        }
        public void StartGame()
        {
            Player person = new Player();
            person.SetPlayersName();
            Day day1 = new Day();
            day1.Day1();
            person.BuyIngredients();
        }
    }
}
