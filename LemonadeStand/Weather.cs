using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        // member variables (HAS A)
        public string weather;
        public int temperature;

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
            Console.WriteLine($"The temperature is: {temperature}\n");

        }
        //public void GenerateWeekForecast()
        //{
        //    for(int i=0; i<7; i++)
        //    {
        //        GenerateWeather();
        //        GenerateTemperature();
        //    }
            
        //    Console.WriteLine($"The weather for the rest of the week is {i}");
        //}
    }
}
