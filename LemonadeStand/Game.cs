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
                    Console.WriteLine("Wonderful! Let's get started with your 7 day adventure by purchasing your ingredients!\n");
                    //instantiate or call method in inventory
                    break;
                case "14":
                    Console.WriteLine("Wonderful! Let's get started with your 14 day adventure by purchasing your ingredients!\n");

                    break;
                case "21":
                    Console.WriteLine("Wonderful! Let's get started with your 21 day adventure by purchasing your ingredients!\n");

                    break;
                default:
                    Console.WriteLine("You must pick either 7, 14, or 21 days to run your lemonade stand business.\n");
                    ChooseDays();
                    break;
            }
        }
    }
}
