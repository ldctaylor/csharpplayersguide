using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//page 88

namespace CsharpPlayersGuide.Exercises
{
    internal class Prototype
    {
        int number;
        public static void PrototypeMethod()
        {
            Prototype pilot = new();
            Prototype guess = new();

            Console.WriteLine("User 1, enter a number between 0 and 100:");
            pilot.number = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("User 2, guess the number.");
                guess.number = Convert.ToInt32(Console.ReadLine());

                if (guess.number > pilot.number) Console.WriteLine($"{guess.number} is too high");
                else if (guess.number < pilot.number) Console.WriteLine($"{guess.number} is too low");
                else break;
            }
            
            Console.WriteLine("You guessed the number!");

        }
    }
}
