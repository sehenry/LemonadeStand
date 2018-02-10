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
        protected double bulkCost;

        public double GetCost()
        {
            return cost;
        }

        public string GetName()
        {
            return name;
        }
        public double GetBulkCost()
        {
            return bulkCost;
        }
    }
}
