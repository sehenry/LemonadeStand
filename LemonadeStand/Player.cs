using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public string lemonadePrice;
       
         public void CostOfLemonade()
        {
            Console.WriteLine("Okay, so now that you know the weather for today, how much do you want to charge for a cup of lemonade? Keep in mind, the colder it is, the less you should charge to try and get more customers. On the flip side, if it's hot, raise those prices! Lemonade will be in high demand!\n");
            string userInput = Console.ReadLine();

            lemonadePrice = userInput;
            Console.ReadLine();

            Game ingredients = new Game();
            ingredients.IngredientPrices();

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
            Console.ReadLine();

            MakeLemonade();
           
        }
        public void MakeLemonade()
        {
            Console.WriteLine("You have your ingredients, now it's time to decide your recipe for your lemonade. Some customers may be more willing to purchase, or pay more if you have more sugar, lemons or ice in your recipe. Keep that in mind.\n");//this is where they decide how much of each ingredient to put in their lemonade
            Console.WriteLine("");//have a writeline for each ingredient, userinput that will add to their inventory for each item, and money that will subtract from their bank based on input
        }
    }
}
