using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public string weather;
        public int temperature;

        public void GetWeather()
        {
            Console.WriteLine("Let's check out the weather so you can better plan your purchases for today. Sound good?\n");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "yes":
                    GenerateWeather();
                    break;
                                 
                default:
                    Console.WriteLine("Please just enter yes. It DOES sound good I promise.");
                    GetWeather();
                    break;
            }
        }
        public void GenerateWeather()
        {
            Random random = new Random();
            string[] weatherOptions =
            {
                "Sunny", "Rainy", "Cloudy", "Mostly Sunny"
            };
            weather = weatherOptions[random.Next(0, weatherOptions.Length)];
            Console.WriteLine($"The weather is: {weather}");
            GenerateTemperature();
        }
        public void GenerateTemperature()
        {
            Random random = new Random();
            int[] temperatureOptions =
            {
                50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100
            };
            temperature = temperatureOptions[random.Next(0, temperatureOptions.Length)];
            Console.WriteLine($"The temperature is: {temperature}");
        }
    }
}
