using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Player bot = new Player();
            Player alex = new Player(VARIANTS.Paper, "alex");
            Console.WriteLine($"name: {alex.name}, var: {alex.VARIANTS}");
            Console.WriteLine($"name: {bot.name}, var: {bot.VARIANTS}");

            Console.WriteLine(bot.whoWins(bot, alex));

            Console.ReadKey();
        }
    }
}
