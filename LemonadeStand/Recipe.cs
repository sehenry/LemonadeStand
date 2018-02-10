using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        public void ComputerRecipe()
        {
            Console.WriteLine("The computer recipe will use 4 lemons, 4 cups of sugar and 4 ice cubes. You can choose to create your own recipe any day you'd like moving forward.\n");

        }

        public void MakeLemonade()
        {
            Console.WriteLine("You have your ingredients, now it's time to decide your recipe for your lemonade. Some customers may be more willing to purchase, or pay more if you have more sugar, lemons or ice in your recipe. Keep that in mind. There are 4 cups in a pitcher.\n");

            Console.WriteLine("How many lemons do you want to use per pitcher? (computer uses 4)\n");
            string userInputLemon = Console.ReadLine();
            int lemonsUsedForRecipe;
            lemonsUsedForRecipe = Int32.Parse(userInputLemon);

            Console.WriteLine("How many cups of sugar do you want to use per pitcher? (computer uses 4)\n");
            string userInputSugar = Console.ReadLine();
            int sugarUsedForRecipe;
            sugarUsedForRecipe = Int32.Parse(userInputSugar);

            Console.WriteLine("How many ice cubes do you want to use per pitcher? (computer uses 4)\n");
            string userInputIce = Console.ReadLine();
            int iceUsedForRecipe;
            iceUsedForRecipe = Int32.Parse(userInputIce);

            Console.ReadLine();
        }
    }
}
