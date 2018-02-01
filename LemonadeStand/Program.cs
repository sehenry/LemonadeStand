using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Game initialGamePlay = new Game();
            initialGamePlay.GameRules();
            Console.ReadLine();

        }
    }
}
