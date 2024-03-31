using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPlayersGuide.Exercises
{
    internal class Text
    {
        public static void PracticeEscaping()
        {
            var v1 = "dgdfhdfhdfh";
            var v2 = "dgsd";
            var v3 = "sdhsdhg sdgsdh sdhgsdh";
            var p1 = "$6.00";
            var p2 = "$63.45";
            var p3 = "$100.00";
            Console.WriteLine("Using the character \\ will escape another character");
            Console.WriteLine("\\r is a carriage return");
            Console.Title = "Escape Characters";
            Console.WriteLine("Here I will practise formatting lines".ToUpper());
            Console.WriteLine($"{v1,-25} costs {p3, 10}");
            Console.WriteLine($"{v2,-25} costs {p2,10}");
            Console.WriteLine($"{v3,-25} costs {p1,10}");
        }
    }
}
