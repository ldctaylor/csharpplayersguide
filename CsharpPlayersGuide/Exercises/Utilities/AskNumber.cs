using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPlayersGuide.Exercises.Utilities
{
    internal class AskNumber
    {
        public static int AskForNumber(string message)
        {
            int number;
            bool success;

            Console.WriteLine(message);

            {
                while (true)
                {
                    string? input = Console.ReadLine();
                    success = int.TryParse(input, out number);

                    if (success)
                    {
                        return number;
                    }
                    else
                    {
                        Console.WriteLine("I told you to use a valid number!!! Try again");
                    }
                }
        }
    }
    }
}
