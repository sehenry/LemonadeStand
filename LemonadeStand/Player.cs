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

        public Player()
        {
            recipe = new Recipe();
            inventory = new Inventory();

        }
        public void GetIngredients()
        {
            //have this for each ingredient they need to but. must be instantiated with the Game class, playerBank method and subtract accordingly. Also
            //must be instantiated with the inventory to keep track of how much the player has
            //will be where the user can purchase each ingredient for their lemonade stand. must instantiate with the method that does the math for the recipe/purchasing
            Console.WriteLine("How many cups would you like?");
            string userInputCup = Console.ReadLine();
            int cupsPurchased;
            cupsPurchased = Int32.Parse(userInputCup);
            
            Console.WriteLine("How many lemons?\n");
            string userInputLemon = Console.ReadLine();
            int lemonsPurchased;
            lemonsPurchased = Int32.Parse(userInputLemon);
           
            Console.WriteLine("How many cups of sugar?\n");
            string userInputSugar = Console.ReadLine();
            int sugarPurchased;
            sugarPurchased = Int32.Parse(userInputSugar);
           
            Console.WriteLine("And, finally, how much ice?\n");
            string userInputIce = Console.ReadLine();
            int icePurchased;
            icePurchased = Int32.Parse(userInputIce);
            
            Console.WriteLine($"So, for today you have {cupsPurchased} cups, {lemonsPurchased} lemons, {sugarPurchased} cups of sugar and {icePurchased} ice cubes. Now, let's make your lemonade recipe!\n");
     
        }
        public void RecipeDecision()//must call this every single day of game play so they can change their mind
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

        public void CostOfLemonade()
        {
            string lemonadePrice;

            Console.WriteLine("You have your inventory, you've made your recipe and you know the weather. Now, how much will you charge for a cup of lemonade? Keep in mind, the colder it is, the less you should charge to try and get more customers. On the flip side, if it's hot, raise those prices! Lemonade will be in high demand!\n");
            string userInput = Console.ReadLine();

            lemonadePrice = userInput;

        }
        public void PlayerBank()
        {

            //this will be the method where the math is done. $200 to start with, keeps updating based on ingredient purchases and customer purchases. running total
        }
    }
}
