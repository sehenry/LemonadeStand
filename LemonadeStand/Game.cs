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
        public Bank bank;
        public Inventory inventory;
        public Day day;

        // constructor (SPAWNER)
        public Game()
        {
            player = new Player();
            store = new Store();
            customer = new Customer();
            days = new List<Day>();
            dayCounter = 0;
            bank = new Bank();
            inventory = new Inventory();
            day = new Day();
        }
        public void RunGame()
        {
            GameRules();
            int numberOfDays = ChooseDays();

            for (int i = 0; i < numberOfDays; i++)
            {

                IngredientPrices(bank);
                player.GetIngredients(store, bank, inventory);
                //cost of ingredients gets subtracted from player bank
                //ingredients get added to inventory
                player.RecipeDecision();
                player.CostOfLemonade();

                //player starts day

                customer.PotentialCustomers();
                day.DailyLemonadesPurchased();
                //bank.AddMoney();
                //inventory.SubtractInventory();

                day.DisplayDailyProfits();
                //inventory.DisplayCurrentStock();


                //inventory subtract the amount of lemons, sugar, cups and ice that were 'purchased' by customers that day
                //each purchased lemonade will subtract the amount of ingredients used per lemonade that the user picked. 
                //game totals the sales for the day
                //inventory subtracts the ingredients used for the day
                //game reports profits to user for the day
                //game reports current inventory to user
                //player moves onto next day and chooses to purchase ingredients, and make recipe again
            }
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
            Console.WriteLine($"You currently have {currentMoney} in your bank. To run a successful Lemonade stand, you're going to need cups, lemons, sugar and ice. You can buy in bulk, using the number shown, or buy a different amount of your choosing.\nCups cost:\n$15.30 for 50 cups, .32 per cup\nLemons cost:\n$22.90 for 30 Lemons, .80 per lemon\nSugar costs:\n$15.70 for 20 cups, .80 per cup of sugar\nIce costs:\n$21.90 for 250 ice cubes, .09 per cube.\n");
        }
        
       
    }
}
