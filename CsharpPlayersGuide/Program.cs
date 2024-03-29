
//The purpose of this is to help P-Thag, a triangle farmer, calculate the area of 
//all his triangles.

using CsharpPlayersGuide.Exercises;

SistersAndDuckBear.DistributeEggs();
SistersAndDuckBear.DuckBearLucky();

int number;

Console.WriteLine("What is the base width of the triangle? Please only enter a number as otherwise the program will break.");

int baseWidth = ConvertToNumber();

Console.WriteLine("...and the height? Numbers only please!");

int height = ConvertToNumber();

float area = (baseWidth * height) / 2F;

Console.WriteLine($"The area of the triangle is {area}");

int ConvertToNumber()
{
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