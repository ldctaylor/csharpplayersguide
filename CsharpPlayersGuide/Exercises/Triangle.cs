using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CsharpPlayersGuide.Exercises
{
    internal class Triangle
    {
        int triangleBase = 0;
        int triangleHeight = 0;

        public Triangle(int b, int h)
    {
            triangleBase = b;
            triangleHeight = h;

    }

        public static Triangle Initialise()
        {
            Console.WriteLine("What is the base width of the triangle? Please only enter a number as otherwise the program will break.");
            int triangleBase = ConvertToNumber();
            Console.WriteLine("...and the height? Numbers only please!");
            int triangleHeight = ConvertToNumber();
            Triangle triangle = new(triangleHeight, triangleBase);
            Console.WriteLine($"Triangle with base {triangle.triangleBase} base and {triangle.triangleHeight} height has been initialised");
            Console.WriteLine("Calculating area...");
            Console.Write($"Area of triangle is {triangle.CalculateArea()}");


            return new Triangle(triangleBase, triangleHeight);
        }

    private float CalculateArea()
    {
        float area = (triangleBase * triangleHeight) / 2F;

            return area;
    }

    static int ConvertToNumber()
    {
        int number;
        bool success;
        {
            do
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
            while (!success);
            return number;
        }
    }
}
}
