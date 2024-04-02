using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPlayersGuide.Exercises
{
    internal class SimulasSoup
    {
        public static (Type type, MainIngredient ingredient, Seasoning seasoning) soup = CookDish();

        public static void PrintDish((Type, MainIngredient, Seasoning) soup) =>
        Console.WriteLine($"We will make a {soup.Item3.ToString().ToLower()} {soup.Item2.ToString().ToLower()} {soup.Item1.ToString().ToLower()}!");

        public static (Type, MainIngredient, Seasoning) CookDish()
        {
            Type type = ChooseType();
           MainIngredient ingredient = ChooseIngredient();
            Seasoning seasoning = ChooseSeasoning();
            
            return (type, ingredient, seasoning);
           
        }
        static Type ChooseType()
        {
            Console.Write("What type of dish would you like? ");
            string? type = Console.ReadLine();

            switch (type)
            {
                case "soup":
                    return Type.Soup;
                case "stew":
                    return Type.Stew;
                case "gumbo":
                    return Type.Gumbo;
                default:
                    Console.WriteLine("Invalid choice. Let's go with soup.");
                    return Type.Soup;
            }
        }

        static MainIngredient ChooseIngredient()
        {
            Console.Write("What main ingredient would you like? ");
            string? ingredient = Console.ReadLine();

            switch (ingredient)
            {
                case "mushrooms":
                    return MainIngredient.Mushrooms;
                case "chicken":
                    return MainIngredient.Chicken;
                case "carrots":
                    return MainIngredient.Carrots;
                default:
                    Console.WriteLine("Invalid choice. Let's go with mushrooms");
                    return MainIngredient.Mushrooms;
            }
        }

        static Seasoning ChooseSeasoning()
        {
            Console.Write("What kind of seasoning - sweet, spicy or salty? ");

            string? seasoning = Console.ReadLine();

            switch (seasoning)
            {
                case "sweet":
                    return Seasoning.Sweet;
                case "spicy":
                    return Seasoning.Spicy;
                case "salty":
                    return Seasoning.Salty;
                default:
                    Console.WriteLine("Invalid choice. Let's go with spicy!!!");
                    return Seasoning.Spicy;
            }
        }

    public enum Type {
            Soup,
            Stew,
            Gumbo
        } 

        public enum MainIngredient
        {
            Mushrooms,
            Chicken,
            Carrots,
            Potatoes
        }

        public enum  Seasoning
        {
            Spicy,
            Salty,
            Sweet
        }
    }
}
