﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LemonadeStand

{
    class Day
    {
        public Weather weather;
        public Inventory inventory;


        public Day()
        {
            weather = new Weather();
            inventory = new Inventory();
        }
        public void GetDay()
        {
            //this method will keep track, and be on a loop day by day as the user plays. will stop and instantiate with the function that ends the game and shows total profits
        }
        public void DailyLemonadesPurchased()//method that will multiply the cost of lemonade by the total customer purchases
        {

        }
        public void DisplayDailyProfits()//subtracts money spent on ingredients, adds money customers spent. gived total money
        {

        }
        private void RunTotalProfits()//adds the profits from every day and gives total profits or money lost on business, end of game
        {

        }
    }
}
