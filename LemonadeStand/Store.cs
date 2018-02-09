using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        public int lemons;
        public int cups;
        public int sugar;
        public int ice;

        public Store()
        {

        }

        public List<Lemons> SellLemons(int itemsBeingSold, Bank bank)
        {
            List<Lemons> newLemons = new List<Lemons>();

            for (int i = 0; i < itemsBeingSold; i++)
            {
                Lemons lemons = new Lemons();
                if (bank.SubtractMoney(lemons.GetCost()))

                    newLemons.Add(new Lemons());
            }
            return newLemons;
        }

        public List<Cups> SellCups(int itemsBeingSold, Bank bank)
        {
            List<Cups> newCups = new List<Cups>();

            for (int i = 0; i < itemsBeingSold; i++)
            {
                Cups cups = new Cups();
                if (bank.SubtractMoney(cups.GetCost()))

                    newCups.Add(new Cups());
            }
            return newCups;
        }
        public List<Sugar> SellSugar(int itemsBeingSold, Bank bank)
        {
            List<Sugar> newSugar = new List<Sugar>();

            for (int i = 0; i < itemsBeingSold; i++)
            {
                Sugar sugar = new Sugar();
                if (bank.SubtractMoney(sugar.GetCost()))

                    newSugar.Add(new Sugar());
            }
            return newSugar;
        }
        public List<Ice> SellIce(int itemsBeingSold, Bank bank)
        {
            List<Ice> newIce = new List<Ice>();

            for (int i = 0; i < itemsBeingSold; i++)
            {
                Ice ice = new Ice();
                if (bank.SubtractMoney(ice.GetCost()))

                    newIce.Add(new Ice());
            }
            return newIce;
        }
    }
}


