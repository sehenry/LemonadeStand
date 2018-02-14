using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public List<Lemons> lemons;
        public List<Cups> cups;
        public List<Sugar> sugar;
        public List<Ice> ice;
        Store store = new Store();
        public Inventory()
        {
            lemons = new List<Lemons>();
            cups = new List<Cups>();
            sugar = new List<Sugar>();
            ice = new List<Ice>();
        }     
        public void BuyLemons(List<Lemons> lemons)
        {
            
            this.lemons.AddRange(lemons);
        }
        public void BuyCups(List<Cups> cups)
        {
            this.cups.AddRange(cups);
        }

        public void BuySugar(List<Sugar> sugar)
        {
            this.sugar.AddRange(sugar);
        }

        public void BuyIce(List<Ice> ice)
        {
            this.ice.AddRange(ice);
        }
        public void SubtractIngredients()
        {
            if(lemons.Count > 0 && ice.Count > 0 && cups.Count >0 && sugar.Count >0)
            {
                lemons.RemoveAt(0);
                ice.RemoveAt(0);
                cups.RemoveAt(0);
                sugar.RemoveAt(0);
            }           
        }
        public bool CheckInventory()
        {
            if (lemons.Count == 0 || cups.Count == 0 || sugar.Count == 0 || ice.Count == 0)
            {
                Console.WriteLine("You ran out of 1 or more ingredients!");
                return false;
            }
            else
            {
                return true;
            }
        }
        public void CurrentInventory()
        {
            Console.WriteLine($"Your current inventory is:\n{lemons.Count} lemons\n{cups.Count} cups\n{sugar.Count} cups of sugar\n{ice.Count} ice cubes\n");
        }
        }
    }

