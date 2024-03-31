using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

//page 94
namespace CsharpPlayersGuide.Exercises
{
    internal class Replicator
    {
        public static void ReplicatorOfDTo()
        {

            Console.WriteLine("The Laws of Freach".ToUpper());
            int[] array = [4, 51, -7, 13, -99, 15, -8, 45, 90];
            int currentSmallest = int.MaxValue;
            int total = 0;
            foreach (int number in array)
            {
                if (number < currentSmallest)
                    currentSmallest = number;
                total += number;
            }
            float average = (float)total / array.Length;
            Console.WriteLine($"The smallest number is {currentSmallest}; and the average is {average:0.00}");


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
