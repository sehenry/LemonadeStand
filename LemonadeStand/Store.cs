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
            Lemons lemons = new Lemons();
            if (itemsBeingSold != 30)
                for (int i = 0; i < itemsBeingSold; i++)
                {
                    if (bank.SubtractMoney(lemons.GetCost()))

                        newLemons.Add(new Lemons());
                }
            else
             if (bank.SubtractMoney(lemons.GetBulkCost()))
            {
                for (int i = 0; i < itemsBeingSold; i++)
                {
                    newLemons.Add(new Lemons());
                }
            }
            return newLemons;
        }

        public List<Cups> SellCups(int itemsBeingSold, Bank bank)
        {
            List<Cups> newCups = new List<Cups>();
            Cups cups = new Cups();
            if (itemsBeingSold != 50)
                for (int i = 0; i < itemsBeingSold; i++)
                {
                    if (bank.SubtractMoney(cups.GetCost()))
                        newCups.Add(new Cups());
                }
            else
                if (bank.SubtractMoney(cups.GetBulkCost()))
            {
                for (int i = 0; i < itemsBeingSold; i++)
                { 
            newCups.Add(new Cups());
                }
            }
            return newCups;
        }
        public List<Sugar> SellSugar(int itemsBeingSold, Bank bank)
        {
            List<Sugar> newSugar = new List<Sugar>();
            Sugar sugar = new Sugar();
            if (itemsBeingSold != 20)
                for (int i = 0; i < itemsBeingSold; i++)
                {
                    if (bank.SubtractMoney(sugar.GetCost()))
                        newSugar.Add(new Sugar());
                }
            else
                if (bank.SubtractMoney(sugar.GetBulkCost()))
            {
                for (int i = 0; i < 2; i++)
                {
                    newSugar.Add(new Sugar());
                }
            }
            return newSugar;
        }
        public List<Ice> SellIce(int itemsBeingSold, Bank bank)
        {
            List<Ice> newIce = new List<Ice>();
            Ice ice = new Ice();
        if(itemsBeingSold != 250)
            for (int i = 0; i < itemsBeingSold; i++)
            {
                if (bank.SubtractMoney(ice.GetCost()))
                   newIce.Add(new Ice());
            }
            else
            if (bank.SubtractMoney(ice.GetBulkCost()))
            {
                for (int i = 0; i < 2; i++)
                {
                    newIce.Add(new Ice());
                }
            }
            return newIce;
        }
    }
}


