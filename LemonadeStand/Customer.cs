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
            for (int i = 0; i < 40; i++)
            {
                    if (player.lemonadePrice < .03 * weather.temperature && player.inventory.CheckInventory())
                { 
                        Purchases.Add(true);
                        player.bank.AddMoney(player.lemonadePrice);
                        player.inventory.SubtractIngredients();
                }
                
                    if (player.lemonadePrice < .02 * weather.temperature && player.inventory.CheckInventory())
                { 
                        Purchases.Add(true);
                        player.bank.AddMoney(player.lemonadePrice);
                        player.inventory.SubtractIngredients();
                }
                
                    if (player.lemonadePrice < .01 * weather.temperature && player.inventory.CheckInventory())
                { 
                        Purchases.Add(true);
                        player.bank.AddMoney(player.lemonadePrice);
                        player.inventory.SubtractIngredients();
                }
            }
            return Purchases;       //each lemonade purchased needs to subtract 1 from each ingredient in the inventory
                                    //each lemonade sold needs to be added to the total lemonades sold in the Day class
                                    //each lemonade purchased needs to add the price of lemonade to the Bank class
                                    //
                                    
        }
    }
}

