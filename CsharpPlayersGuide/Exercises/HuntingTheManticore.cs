using CsharpPlayersGuide.Exercises.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPlayersGuide.Exercises
{
    internal class HuntingTheManticore
    {
        public static void PlayManticoreGame()
        {
            int attackRange = AskNumber.AskForNumberInRange("Player 1, how far away from the city do you want to station the Manticore? ", 0, 101);
            int healthManticore = 10;
            int healthConsolas = 15;
            int round = 1;

            Console.Clear();
            Console.WriteLine("Player 2, it is your turn.");

            while (true)
            {
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine($"STATUS: Round: {round} City: {healthConsolas}/15 Manticore: {healthManticore}/10");
                int damage = Cannon.FireCannon(round);
                Console.WriteLine($"The cannon is expected to deal {damage} this round.");
                int range = AskNumber.AskForNumberInRange("Enter desired cannon range: ", 0, 101);

                if (range < attackRange)
                    Console.WriteLine("That round FELL SHORT of the target.");
                else if (range > attackRange)
                    Console.WriteLine("That round OVERSHOT the target.");
                else
                {
                    Console.WriteLine("That round was a DIRECT HIT!");
                    healthManticore -= damage;
                }
                healthConsolas--;

                if (healthManticore <= 0 && healthConsolas <= 0)
                {
                    Console.WriteLine("Both the Manticore and the city of Consolas have been destroyed! Bad luck!");
                    Console.Beep(450, 1000);
                    return;
                }
                else if (healthManticore <= 0)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
                    Console.Beep(450, 1000);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                else if (healthConsolas <= 0)
                {
                    Console.WriteLine("The city of Consolas has been destroyed! The Manticore has won! Bad luck!!");
                    Console.Beep(450, 1000);
                    return;
                }
                round++;
            }
        }
    }
}
