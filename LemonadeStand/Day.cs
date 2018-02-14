using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LemonadeStand

{
    class Day
    {
        public Weather weather;
       
        public Customer customer;


        public Day()
        {
            weather = new Weather();
            
            customer = new Customer();
        }
        public void GetDay()
        {           
        }
        public void DailyLemonadesPurchased(int sales)
        {
            Console.WriteLine($"You sold {sales} lemonades");
        }
        public void DisplayDailyProfits()
        {

        }
        private void RunTotalProfits()
        {

        }
    }
}
