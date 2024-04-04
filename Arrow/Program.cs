
namespace ArrowMaker
{
    public class Program
{
    static void Main(string[] args)
    {
        Arrow arrow = MakeArrow();
        Console.WriteLine("Your arrow costs " + arrow.GetCost() + " gold.");

    }
        public static Arrow MakeArrow()
        {
            Arrowhead arrowhead = Utility.ChooseArrowHead();
            Fletching fletching = Utility.ChooseFletching();
            float length = Utility.ChooseLength();

            return new Arrow(arrowhead, fletching, length);

        }

    }

    static public class Utility
    {
        static public Arrowhead ChooseArrowHead()
        {
            Console.Write("What arrowhead would you like? Choose from steel, wood, or obsidian: ");
            string? arrowhead = Console.ReadLine();

            switch (arrowhead)
            {
                case "steel":
                    return Arrowhead.Steel;
                case "wood":
                    return Arrowhead.Wood;
                case "obsidian":
                    return Arrowhead.Obsidian;
                default:
                    Console.WriteLine("Invalid choice. Let's go with steel.");
                    return Arrowhead.Steel;
            }

        }

        public static Fletching ChooseFletching()
        {
            Console.Write("What fletching would you like? Choose from plastic, turkey feathers, or goose feathers: ");
            string? fletching = Console.ReadLine();

            switch (fletching)
            {
                case "plastic":
                    return Fletching.Plastic;
                case "turkey feathers":
                    return Fletching.TurkeyFeathers;
                case "goose feathers":
                    return Fletching.GooseFeathers;
                default:
                    Console.WriteLine("Invalid choice. Let's go with plastic.");
                    return Fletching.Plastic;
            }
        }

        public static float ChooseLength()
        {
            Console.Write("What length would you like your arrow? Choose between 60 - 100cm: ");
            float length = Convert.ToInt32(Console.ReadLine());
            if (length < 60 || length > 100)
            {
                Console.WriteLine("Invalid choice. Let's go with 60cm.");
                return 60;
            }
            else
            {
                return length;
            }
        }
    }

    public class Arrow
    {
        public Arrowhead _arrowhead;
        public Fletching _fletching;
        public float _length;

        public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
        {
            _arrowhead = arrowhead;
            _fletching = fletching;
            _length = length;
        }

        public float GetCost()
        {
            float arrowheadCost = _arrowhead switch
            { Arrowhead.Steel => 10, Arrowhead.Wood => 3, Arrowhead.Obsidian => 5 };

            float lengthCost = 0.05f * _length;

            float fletchingCost = _fletching switch { 
                Fletching.Plastic => 10, 
                Fletching.TurkeyFeathers => 5, 
                Fletching.GooseFeathers => 3 };

            return arrowheadCost + lengthCost + fletchingCost;
        }
    }
    public enum Arrowhead
    {
        Steel,
        Wood,
        Obsidian
    }

    public enum Fletching
    {
        Plastic,
        TurkeyFeathers,
        GooseFeathers
    }
}