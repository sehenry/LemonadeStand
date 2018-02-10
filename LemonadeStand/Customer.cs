using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {

        public Customer()
        {
        }
        public List<bool> PotentialCustomers (Weather weather, Player player)

        {
            List<bool> Purchases = new List<bool>();
            for (int i = 0; i < 100; i++)

            {
                Random random = new Random(); //create random percentage of people that actually buy, probability

                if (player.CostOfLemonade() < .06 * weather.temperature && player.inventory.CheckInventory())
                    Purchases.Add(true);
                    
            }
            return Purchases;
        }
    }
}

