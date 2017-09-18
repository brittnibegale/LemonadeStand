using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        double numberOfPotentialCustomers;
        double totaleffectedCustomers;
        double totalCustomersThatBuy;
        public Customer()
        {
            numberOfPotentialCustomers = 60;
        }

        public void CompareRecipeToCustomers(List<double>recipe, double weatherEffectedCustomers)
        {
            if (recipe[0]-recipe[1] == 2)
            {
                totaleffectedCustomers = weatherEffectedCustomers + 2;
            }
            else if (recipe[0] - recipe[1] == 1 || recipe[0] - recipe[1] == 3)
            {
                totaleffectedCustomers = weatherEffectedCustomers + 6;
            }
            else if (recipe[0] - recipe[1] == 0)
            {
                totaleffectedCustomers = weatherEffectedCustomers + 8;
            }
            else
            {
                totaleffectedCustomers = weatherEffectedCustomers + 10;
            }

        }
        public double SetAmountOfServedCustomers()
        {
            totalCustomersThatBuy = numberOfPotentialCustomers - totaleffectedCustomers;
            return totalCustomersThatBuy;
        }

    }
}
