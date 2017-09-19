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
        public List<Cups> cup = new List<Cups>();
        double pitchers;

        public Inventory()
        {

        }
        
        public void DisplayInventory()
        {
            Console.WriteLine("You have " + lemons.Count + " lemons in your inventory." + " \n You have " + ice.Count + " ice cubes in your inventory." + "\n You have " + sugar.Count + " packets of sugar in your inventory." + "\n You have " + cup.Count + " cups in your inventory.");
            Console.ReadLine();
        }

        public void AddLemonList(double item)
        {
            for (int i = 0; i < item; i++)
            {
                lemons.Add(new Lemons());
            }
        }

        public void RemoveLemons(double item)
        {
            for (int i = 0; i < item; i++)
            {
                lemons.RemoveAt(0);
            }
        }

        public void AddSugarList(double item)
        {
            for (int i = 0; i < item; i++)
            {
                sugar.Add(new Sugar());
            }
        }

        public void RemoveSugar(double item)
        {
            for(int i = 0; i < item; i++)
            {
                sugar.RemoveAt(0);
            }
        }

        public void AddIceList(double item)
        {
            for (int i = 0; i < item; i++)
            {
                ice.Add(new Ice());
            }
        }

        public void RemoveIce(double item)
        {
            for (int i = 0; i < item; i++)
            {
                ice.RemoveAt(0);
            }
        }

        public void AddCupList(double item)
        {
            for (int i = 0; i < item; i++)
            {
                cup.Add(new Cups());
            }
        }

        public void RemoveCups(double item)
        {
            for (int i = 0; i < item; i++)
            {
                cup.RemoveAt(0);
            }
        }

        public double CheckCups(double inventoryCups)
        {
            double unroundedPitchers = inventoryCups / 6;
            pitchers = Math.Floor(unroundedPitchers);
           
            return pitchers;
        }
       
        public double CheckIceSugarLemons(double recipeAmount, double inventoryOfItem, double pitchers)
        {
            while (true)
            {
                double newInventoryOfItem = inventoryOfItem - (pitchers * recipeAmount);
                if(newInventoryOfItem >= 0)
                {
                    return pitchers;
                }
                else
                {
                    pitchers = pitchers - 1;
                }
            }
        }
    }
}
