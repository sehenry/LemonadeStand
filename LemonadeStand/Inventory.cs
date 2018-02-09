using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        List<Lemons> lemons;
        List<Cups> cups;
        List<Sugar> sugar;
        List<Ice> ice;

        public Inventory()
        {
            lemons = new List<Lemons>();
            cups = new List<Cups>();
            sugar = new List<Sugar>();
            ice = new List<Ice>();
        }

        public void BuyLemons(int numberToBuy, Bank bank)
        {
            Store store = new Store();
            lemons.AddRange(store.SellLemons(numberToBuy, bank));
        }
    }
}
