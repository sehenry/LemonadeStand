using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public string lemonadePrice;
        public void MakeLemonade()
        {

        }
         public void CostOfLemonade()
        {
            Console.WriteLine("Okay, so now that you know the weather for today, how much do you want to charge for a cup of lemonade? Keep in mind, the colder it is, the less you should charge to try and get more customers. On the flip side, if it's hot, raise those prices! Lemonade will be in high demand!\n");
            string userInput = Console.ReadLine();

            lemonadePrice = userInput;

        }
    }
}
