using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Items
    {
        protected double cost;
        protected string name;

        public double GetCost()
        {
            return cost;
        }

        public string GetName()
        {
            return name;
        }
    }
}
