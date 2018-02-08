using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game // IS A
    {
        // member variables (HAS A)
        public Player player;
        public Store store;
        public Customer customer;
        public List<Day> days;
        public int dayCounter;

        // constructor (SPAWNER)
        public Game()
        {
            player = new Player();
            store = new Store();
            customer = new Customer();
            days = new List<Day>();
            dayCounter = 0;
        }
        public void RunGame()
        {
            GameRules();
            ChooseDays();
            //LOOP STARTS HERE
            //for(int i = 0; i < 7; i++)
            //{
            //    days.Add(new Day());
            //}

            IngredientPrices();
            player.GetIngredients();
            player.RecipeDecision();
            player.CostOfLemonade();
            //game rules, user learns how to play the game
            //player chooses how many days they want to play
       
            
            //player gets shown cost of ingredients
            //player buys ingredients from store
            //cost of ingredients gets subtracted from player bank
            //ingredients get added to inventory
            //player makes recipe, or uses computer recipe         
            //weather gets checked for the day
            //player decides how much to charge for lemonade
            //player starts day
            //customers 'buy' lemonade based on their designated preferences on weather, cost, recipe of lemonade
            //inventory subtract the amount of lemons, sugar, cups and ice that were 'purchased' by customers that day
            //each purchased lemonade will subtract the amount of ingredients used per lemonade that the user picked. 
            //game totals the sales for the day
            //inventory subtracts the ingredients used for the day
            //game reports profits to user for the day
            //game reports current inventory to user
            //player moves onto next day and chooses to purchase ingredients, and make recipe again
        }

        // member methods (CAN DO)
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
        }
        
       
    }
}
