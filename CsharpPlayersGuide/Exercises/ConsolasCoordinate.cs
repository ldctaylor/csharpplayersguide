﻿using CsharpPlayersGuide.Exercises.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// page 68 

namespace CsharpPlayersGuide.Exercises
{
    internal class ConsolasCoordinate
    {
        int coordinateX = 0;
        int coordinateY = 0;

        private ConsolasCoordinate(int x, int y)
        {
            coordinateX = x;
            coordinateY = y;
        }

        public void DefendConsolas(ConsolasCoordinate attack)
        {
            ConsolasCoordinate defence1 = new(attack.coordinateX + 1, attack.coordinateY);
            ConsolasCoordinate defence2 = new(attack.coordinateX, attack.coordinateY + 1);
            ConsolasCoordinate defence3 = new(attack.coordinateX - 1, attack.coordinateY);
            ConsolasCoordinate defence4 = new(attack.coordinateX, attack.coordinateY - 1);

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Deployment Instructions:".ToUpper());
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            ConsolasCoordinate[] deployments = [defence1, defence2, defence3, defence4];

            Console.WriteLine("Deploy to:");
            foreach (ConsolasCoordinate deployment in deployments)
            {
                Console.WriteLine($"({deployment.coordinateX}, {deployment.coordinateY})");
                Console.Beep(450, 1000);
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;


        }

        public static void AttackConsolas()
        {
            int targetRow = AskNumber.AskForNumber("What is the target row for the attack? ");
            int targetColumn = AskNumber.AskForNumber("\nWhat is the target column for the attack? ");

            ConsolasCoordinate attack = new(targetRow, targetColumn);

            attack.DefendConsolas(attack);
        }
    }



}
