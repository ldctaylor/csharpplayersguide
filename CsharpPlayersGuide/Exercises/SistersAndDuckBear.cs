using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// p56, The Four Sisters and the Duck-Bear
// I am using a different class for each exercise.
// The program needs to tell each sister how many eggs they will get and 
// how many go to the duckbear. Which quantities of eggs will result in the 
//duckbear getting the most eggs?

namespace CsharpPlayersGuide.Exercises
{
    internal static class SistersAndDuckBear
    {
        static int sister, duckbear, totalEggs = 0;
        static int numberOfSiblings = 4;

        public static void DistributeEggs()
        {
            Console.WriteLine("How many chocolate eggs were gathered today?");
            totalEggs = int.Parse(Console.ReadLine());
            duckbear = totalEggs % numberOfSiblings;
            sister = totalEggs / numberOfSiblings;
            string pluralise = (sister == 1 ? "" : "s");
            string duckbearPluralise = (duckbear == 1 ? "" : "s");
            Console.WriteLine(sister + " egg" + pluralise + " for each sister and " + duckbear + " egg" + duckbearPluralise + " for the duckbear.");
        }

        public static void DuckBearLucky()
        {
           Console.WriteLine("Duckbear is lucky when he gets more eggs than the sisters:");
            for (int i = 0; i < 100; i++)
            {
                sister = i / numberOfSiblings;
                duckbear = i % numberOfSiblings;
                if (duckbear > sister)
                {
                    Console.WriteLine($"Ttotal of {i} eggs - sisters get {sister} and he gets {duckbear}");
                }
            }
            Console.WriteLine("Lucky duckbear!");
        }

    }
}
