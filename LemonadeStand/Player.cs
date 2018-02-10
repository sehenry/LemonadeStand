using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public Inventory inventory;
        public Recipe recipe;
        public Bank bank;


        public Player()
        {
            recipe = new Recipe();
            inventory = new Inventory();
            bank = new Bank();

        }
        public void GetIngredients(Store store, Bank bank)
        {

            Console.WriteLine("How many cups would you like?");
            string userInputCup = Console.ReadLine();
            int cupsPurchased;
            cupsPurchased = Int32.Parse(userInputCup);
            inventory.BuyCups(store.SellCups(cupsPurchased, bank));
            
            Console.WriteLine("How many lemons?\n");
            string userInputLemon = Console.ReadLine();
            int lemonsPurchased;
            lemonsPurchased = Int32.Parse(userInputLemon);
            inventory.BuyLemons(store.SellLemons(lemonsPurchased, bank));

            Console.WriteLine("How many cups of sugar?\n");
            string userInputSugar = Console.ReadLine();
            int sugarPurchased;
            sugarPurchased = Int32.Parse(userInputSugar);
            inventory.BuySugar(store.SellSugar(sugarPurchased, bank));

            Console.WriteLine("And, finally, how much ice?\n");
            string userInputIce = Console.ReadLine();
            int icePurchased;
            icePurchased = Int32.Parse(userInputIce);
            inventory.BuyIce(store.SellIce(icePurchased, bank));

            Console.WriteLine($"So, for today you have {cupsPurchased} cups, {lemonsPurchased} lemons, {sugarPurchased} cups of sugar and {icePurchased} ice cubes. Now, let's make your lemonade recipe!\n");
     
        }
        public void RecipeDecision()
        {
            Console.WriteLine("If you would like to use the standard recipe that has already been set, type 'computer recipe'. You may want to use this option if you are just starting out. If you want to make your own recipe, please enter 'hell yes'.\n");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "computer recipe":
                    recipe.ComputerRecipe();
                    break;
                case "hell yes":
                    recipe.MakeLemonade();
                    break;
                default:
                    Console.WriteLine("Please enter 'computer recipe' to utilize our pre-made lemonade recipe or 'hell yes' to create your own!\n");
                    RecipeDecision();
                    break;
            }
        }

        public double CostOfLemonade()
        {
            double lemonadePrice = 0;

            Console.WriteLine("You have your inventory, you've made your recipe and you know the weather. Now, how much will you charge for a cup of lemonade? Keep in mind, the colder it is, the less you should charge to try and get more customers. On the flip side, if it's hot, raise those prices! Lemonade will be in high demand!\n");
            string userInput = Console.ReadLine();

            lemonadePrice= Double.Parse(userInput);
            return lemonadePrice;
        }
        
      
    }
}
