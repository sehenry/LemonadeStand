using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        public void GameRules()
        {
            Console.WriteLine("Welcome to Lemonade Stand! You will have a $200 budget to start your business.\nThe goal of the game is to make as much money you can in 7, 14, or 21 days.\nYou will buy cups, lemons, sugar and ice each day.\nYou must take into account the weather every day and plan accordingly! The colder it is, the less likely your customers will be to purchase lemonade, so think about lowering the cost of your lemonade. On those hot days, try charging more!\nAt the end of the game, you'll see how much money you've grossed!\nAre you ready to play?");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "yes":
                    ChooseDays();
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
        public void ChooseDays()
        {
            Console.WriteLine("How many days would you like to play for? 7, 14 or 21?\n");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "7":                    
                case "14":                    
                case "21":
                    Console.WriteLine($"Wonderful! Let's get started with your {userInput} day adventure by checking out the weather today!\n");
                    Weather weather = new Weather();
                    weather.GenerateWeather();
                    break;
                default:
                    Console.WriteLine("You must pick either 7, 14, or 21 days to run your lemonade stand business.\n");
                    ChooseDays();
                    break;
            }
        }
        public void IngredientPrices()
        {
            Console.WriteLine("You are starting the game with $200. To run a successful Lemonade stand, you're going to need cups, lemons, sugar and ice.\nCups cost:\n$15.30 for 50 cups\nLemons cost:\n$22.90 for 30 Lemons\nSugar costs:\n$15.70 for 20 cups\nIce costs:\n$21.90 for 250 ice cubes.\n");
            //put this in userInterface class? and create new method in Game class that does the actual math for the ingredients?
            Player recipe = new Player();
            recipe.GetIngredients();
        }
        public void PlayerBank()
        {
            

            //this will be the method where the math is done. $200 to start with, keeps updating based on ingredient purchases and customer purchases. running total
        }
    }
}
