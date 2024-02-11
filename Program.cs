using System.Drawing;
using StunningPancake;

namespace StunningPancake
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            System.Console.Write("please insert x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("please insert y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("please insert x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("please insert y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Coordinate coordinate1 = new Coordinate(x1, y1);
            Coordinate coordinate2 = new Coordinate(x2, y2);
            bool check = coordinate1.Check(coordinate2);
        }
        
    }
    public struct Coordinate
    {
        public readonly int x;
        public readonly int y;
        public Coordinate(int X, int Y)
        {
            x = X;
            y = Y;
        }
        public bool Check(Coordinate coordinate)
        {
            bool check = false;
            if (coordinate.x == x && coordinate.y == y)
            {
                System.Console.WriteLine($"The coordinates are the same.");
            }
            else if ((coordinate.x == x && coordinate.y == (y + 1)) || (coordinate.x == x && coordinate.y == (y - 1)) || (coordinate.x == (x + 1) && coordinate.y == y) || (coordinate.x == (x - 1) && coordinate.y == y))
            {
                System.Console.WriteLine("The coordinates are adjacent.");
                check = true;
            }
            else
            {
                System.Console.WriteLine("The coordinates are not adjacent nor the same.");
            }
            return check;
        }
    }
}