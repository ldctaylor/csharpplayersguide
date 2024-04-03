class Program
{
    static void Main()
    {

        Arrow arrow = MakeArrow();
        Console.WriteLine("Your arrow costs " + arrow.GetCost() + " gold.");

        Arrow MakeArrow()
        {
            Arrowhead arrowhead = ChooseArrowHead();
            Fletching fletching = ChooseFletching();
            float length = ChooseLength();

            return new Arrow(arrowhead, fletching, length);

        }

        Arrowhead ChooseArrowHead()
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

        Fletching ChooseFletching()
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

        float ChooseLength()
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
    class Arrow
    {
        Arrowhead _arrowhead;
        Fletching _fletching;
        float _length;

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
    enum Arrowhead
    {
        Steel,
        Wood,
        Obsidian
    }

    enum Fletching
    {
        Plastic,
        TurkeyFeathers,
        GooseFeathers
    }

    }

