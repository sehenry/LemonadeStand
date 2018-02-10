using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Bank
    {
        double playerMoney = 200;

        public double GetBalance()
        {
            return playerMoney;
        }

        public double AddMoney(double profitAmount)
        {
            playerMoney += profitAmount;

            return profitAmount;      
        }
       
        public bool SubtractMoney(double costAmount)
        {
            
            if (playerMoney - costAmount >= 0)
            {
                playerMoney -= costAmount;
                return true;
            }
            return false;
        }
    }
}
