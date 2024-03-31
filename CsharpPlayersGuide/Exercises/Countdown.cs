using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Page 107 - Recursion!

namespace CsharpPlayersGuide.Exercises
{
    internal class Countdown
    {
        public static void CountDown()
        {
            for (int x = 10; x > 0; x--)
                Console.WriteLine(x);
        }

        public static void Recurse(int number)
        {
            if (number == 0) return;
            Console.WriteLine(number);
            Recurse(number - 1);

        }
    }
}
