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
            int length = 200;
            for (int i = 0; i < 20; i++)
            {
                Console.Beep(frequency += 80, length);
            }
        }
    }
}
