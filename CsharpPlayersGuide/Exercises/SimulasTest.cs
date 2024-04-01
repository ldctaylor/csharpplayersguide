using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPlayersGuide.Exercises
{
    internal class SimulasTest
    {
        static ChestState state = ChestState.Locked;

        public static void ReportChestStatus()
        {
            while (true)
            {
                Console.WriteLine($"The chest is {state}. What do you want to do?");
                string action = Console.ReadLine();
                if (state == ChestState.Locked && action == "unlock" || state == ChestState.Open && action == "close")
                    state = ChestState.Closed;
                if (state == ChestState.Closed && action == "open")
                    state = ChestState.Open;
                if (state == ChestState.Closed && action == "lock")
                    state = ChestState.Locked;
                if (action == "q")
                    break;
            }
        }

        enum ChestState
        {
            Locked,
            Closed,
            Open
        }
    }
}
