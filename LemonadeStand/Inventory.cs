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
        Store store = new Store();
        public void BuyLemons(int numberToBuy, Bank bank)
        {
            
            lemons.AddRange(store.SellLemons(numberToBuy, bank));
        }

        public void BuyCups(int numberToBuy, Bank bank)
        {
            cups.AddRange(store.SellCups(numberToBuy, bank));
        }

        public void BuySugar(int numberToBuy, Bank bank)
        {
            sugar.AddRange(store.SellSugar(numberToBuy, bank));
        }

        public void BuyIce(int numberToBuy, Bank bank)
        {
            ice.AddRange(store.SellIce(numberToBuy, bank));
        }
    }
}
