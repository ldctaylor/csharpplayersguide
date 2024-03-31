using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

//p89

namespace CsharpPlayersGuide.Exercises
{
    internal class Cannon
    {
        public static void FireCannon()
        {

            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{i}: Electric and fire");
                    continue;
                }

                else if (i % 3 == 0)
                { 

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{i}: Fire");

                }

                else if (i % 5 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{i}: Electric");
                }

                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine($"{i}: Normal");
                }
            }
        }
    }
}
