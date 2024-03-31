using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//page 94
namespace CsharpPlayersGuide.Exercises
{
    internal class Replicator
    {
        public static void ReplicatorOfDTo()
        {
            int[] array1 = new int[5];
        
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Give me a number please; ");
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] array2 = array1;

            for (int i = 0; i < array1.Length; i++)
                Console.WriteLine ($"Index {i} is {array1[i]} and {array2[i]};");

        }
    }
}
