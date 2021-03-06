﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        public Player player;
        public Store store;
        public Customer customer;
        public List<Day> days;
        public int dayCounter;
        public Day day;
        public Weather weather;

        public Game()
        {
            player = new Player();
            store = new Store();
            customer = new Customer();
            days = new List<Day>();
            dayCounter = 0;
            day = new Day();
            weather = new Weather();          
        }
        public void RunGame()
        {
            GameRules();
            int numberOfDays = ChooseDays();
            for (int i = 0; i < numberOfDays; i++)
            {

                IngredientPrices(player.bank);
                player.GetIngredients(store);
                player.RecipeDecision();
                weather.GenerateWeather();
                player.CostOfLemonade();

                int sales = customer.PotentialCustomers(weather, player).Count;
                day.DailyLemonadesPurchased(sales);
                day.DisplayDailyProfits();
                player.inventory.CurrentInventory();
            }
        }
        public void GameRules()
        {
            Console.WriteLine("Welcome to Lemonade Stand! You will have a $200 budget to start your business.\nThe goal of the game is to make as much money you can in 7, 14, or 21 days.\nYou will buy cups, lemons, sugar and ice each day.\nYou must take into account the weather every day and plan accordingly! The colder it is, the less likely your customers will be to purchase lemonade, so think about lowering the cost of your lemonade. On those hot days, try charging more!\nAt the end of the game, you'll see how much money you've grossed!\nAre you ready to play?");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "yes":                   
                    break;
                case "no":
                    GameRules();
                    break;
                default:
                    Console.WriteLine("You must answer yes or no\n");
                    GameRules();
                    break;
            }
        }
        public int ChooseDays()
        {
            Console.WriteLine("How many days would you like to play for? 7, 14 or 21?\n");
            string userInput = Console.ReadLine();
            int numberOfDays = 0;

            switch (userInput)
            {
                case "7":                
                case "14":                    
                case "21":
                    numberOfDays = Int32.Parse(userInput);
                    Console.WriteLine($"Wonderful! Let's get started with your {userInput} day adventure!\n");                             
                    break;
                default:
                    Console.WriteLine("You must pick either 7, 14, or 21 days to run your lemonade stand business.\n");
                    ChooseDays();
                    break;
            }
            return numberOfDays;
        }
        public void IngredientPrices(Bank bank)
        {
           double currentMoney = bank.GetBalance();
            Console.WriteLine($"You currently have {currentMoney} in your bank. You can buy in bulk, using the number shown, or buy a different amount of your choosing.\nCups cost:\n$15.30 for 50 cups, .32 per cup\nLemons cost:\n$22.90 for 30 Lemons, .80 per lemon\nSugar costs:\n$15.70 for 20 cups, .80 per cup of sugar\nIce costs:\n$21.90 for 250 ice cubes, .09 per cube.\n");
        }      
    }
}
