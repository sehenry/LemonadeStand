using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public void IngredientPrices()
        {
            Console.WriteLine("To run a successful Lemonade stand, you're going to need cups, lemons, sugar and ice.\nCups cost:\n$15.30 for 50 cups\nLemons cost:\n$22.90 for 30 Lemons\nSugar costs:\n$15.70 for 20 cups\nIce costs:\n$21.90 for 250 ice cubes.\n");
            Weather weather = new Weather();
            weather.GetWeather();
           
        }
    

    }
}
