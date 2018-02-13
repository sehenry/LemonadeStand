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
            //this method will keep track, and be on a loop day by day as the user plays. will stop and instantiate with the function that ends the game and shows total profits
        }
        public void DailyLemonadesPurchased(int sales)
        {
            Console.WriteLine($"You sold {sales} lemonades");
        }
        public void DisplayDailyProfits()//subtracts money spent on ingredients, adds money customers spent. gived total money
        {

        }
        private void RunTotalProfits()
        {

        }
    }
}
