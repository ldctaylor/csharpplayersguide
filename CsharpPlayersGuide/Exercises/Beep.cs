using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPlayersGuide.Exercises
{
    internal class Beep
    {
        public static void BeepBoop()
        {
            int frequency = 250;
            int length = 400;
            for (int i = 0; i < 15; i++)
            {
                Console.Beep(frequency += 50, length += 60);
            }
        }
    }
}
