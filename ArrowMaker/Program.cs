
Arrow arrow = GetArrow();
Console.WriteLine($"Your selected arrow is made of {arrow._arrowhead}, with a {arrow._fletching} fletching and a shaft length of {arrow._shaft}.");

Arrowhead GetArrowHead()
        {
            Console.Write("Please choose your arrowhead: steel, wool, or obsidian. ");
            string? input = Console.ReadLine();
            switch (input)
            {
                case "steel": return Arrowhead.Steel;
                case "wool": return Arrowhead.Wool;
                case "obsidian": return Arrowhead.Obsidian;
                default: return Arrowhead.Steel;
            }
        }

        Fletching GetFletching()
        {
            Console.Write("Please choose your fletching: plastic, turkey feathers, or goose feathers. ");
            string? input = Console.ReadLine();
            switch (input)
            {
                case "plastic": return Fletching.Plastic;
                case "turkey feathers": return Fletching.TurkeyFeathers;
                case "obsidian": return Fletching.GooseFeathers;
                default: return Fletching.Plastic;
            }
        }

        int GetShaft()
        {
            Console.Write("Please enter the length of your arrow shaft (60-100): ");
            int shaft = Convert.ToInt32(Console.ReadLine());
            if (shaft >= 60 && +shaft <= 100)
            {
                return shaft;
            }
            else
            {
                Console.WriteLine(shaft + " is not a valid shaft length. Default length of 75 applied.");
                return shaft = 75;
            }
        }


public class Arrow
{
    Arrowhead _arrowhead;
    int _shaft;
    Fletching _fletching;

    public void GetArrow()
    {
        GetArrowHead();

    }
    public Arrow(Arrowhead arrowhead, int shaft, Fletching fletching)
    {
        _arrowhead = arrowhead;
        _shaft = shaft;
        _fletching = fletching;
    }
}
public enum Arrowhead
    {
        Steel,
        Wool,
        Obsidian
    }

    public enum Fletching
    {
        Plastic,
        TurkeyFeathers,
        GooseFeathers
    }
       