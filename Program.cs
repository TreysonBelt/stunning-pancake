namespace StunningPancake
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            Sword sword = new Sword();
            ConsoleColor color = ConsoleColor.Blue;
            ColoredItem<Sword, ConsoleColor> coloredItem = new ColoredItem<Sword, ConsoleColor>(sword, color);
            coloredItem.Display();
            Bow bow = new Bow();
            ConsoleColor color1 = ConsoleColor.Red;
            ColoredItem<Bow, ConsoleColor> coloredItem1 = new ColoredItem<Bow, ConsoleColor>(bow, color1);
            coloredItem1.Display();
            Axe axe = new Axe();
            ConsoleColor color2 = ConsoleColor.Green;
            ColoredItem<Axe, ConsoleColor> coloredItem2 = new ColoredItem<Axe, ConsoleColor>(axe, color2);
            coloredItem2.Display();
        }
    }

    public class Sword { }
    public class Bow { }
    public class Axe { }

    class ColoredItem<Tfirst, Tseccond>
    {
        public Tfirst item { get; set; }
        public Tseccond color { get; }
        public ColoredItem(Tfirst Item, Tseccond Color)
        {
            item = Item;
            color = Color;
        }
        public void Display()
        {
            switch (color)
            {
                case ConsoleColor.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case ConsoleColor.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case ConsoleColor.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            System.Console.WriteLine(item);
            Console.ResetColor(); // Reset color to default
        }
    }

}
