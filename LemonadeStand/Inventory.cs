using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public List<Lemons> lemons = new List<Lemons>();
        public List<Ice> ice = new List<Ice>();
        public List<Sugar> sugar = new List<Sugar>();
        public List<Cups> cup = new List<Cups>();// figure out how to move this to the constructor
        public Inventory()
        {
        }
        
        public void DisplayInventory(int lemons, int ice, int sugar, int cups)
        {
            Console.WriteLine("You have " + lemons + " lemons in your inventory." + "You have " + ice + " ice cubes in your inventory." + "You have " + sugar + " packets of sugar in your inventory." + "You have " + cups + " cups in your inventory.");
            Console.ReadLine();
        }

        public void AddLemonList(int item)
        {
            for (int i = 0; i < item; i++)
            {
                lemons.Add(new Lemons());
            }
        }
        public void RemoveLemons(int item)
        {
            for (int i = 0; i < item; i++)
            {
                lemons.Remove(new Lemons());
            }
        }
        public void AddSugarList(int item)
        {
            for (int i = 0; i < item; i++)
            {
                sugar.Add(new Sugar());
            }
        }
        public void RemoveSugar(int item)
        {
            for(int i = 0; i < item; i++)
            {
                sugar.Remove(new Sugar());
            }
        }
        public void AddIceList(int item)
        {
            for (int i = 0; i < item; i++)
            {
                ice.Add(new Ice());
            }
        }
        public void RemoveIce(int item)
        {
            for (int i = 0; i < item; i++)
            {
                ice.Remove(new Ice());
            }
        }
        public void AddCupList(int item)
        {
            for (int i = 0; i < item; i++)
            {
                cup.Add(new Cups());
            }
        }
        public void RemoveCups(int item)
        {
            for (int i = 0; i < item; i++)
            {
                cup.Remove(new Cups());
            }
        }
    }
}
