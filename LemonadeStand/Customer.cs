using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        int numberOfPotentialCustomers;
        int totaleffectedCustomers;
        int totalCustomersThatBuy;
        public Customer()
        {
            numberOfPotentialCustomers = 60;
        }

        public void CompareRecipeToCustomers(List<int>recipe, int weatherEffectedCustomers)
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
        public int SetAmountOfServedCustomers()
        {
            totalCustomersThatBuy = numberOfPotentialCustomers - totaleffectedCustomers;
            return totalCustomersThatBuy;
        }

    }
}
