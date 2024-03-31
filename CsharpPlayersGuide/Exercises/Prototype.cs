using CsharpPlayersGuide.Exercises.Utilities;
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

            pilot.number = AskNumber.AskForNumberInRange("User 1, enter a number between 0 and 100:",0,100);

            while (true)
            {
                guess.number = AskNumber.AskForNumber("User 2, guess the number.");

                if (guess.number > pilot.number) Console.WriteLine($"{guess.number} is too high");
                else if (guess.number < pilot.number) Console.WriteLine($"{guess.number} is too low");
                else break;
            }
            
            Console.WriteLine("You guessed the number!");

        }
    }
}
