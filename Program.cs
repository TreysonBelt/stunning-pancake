using System.Drawing;
using StunningPancake;

namespace StunningPancake
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            Shape shape = new Shape();
            int l = 3;
            int w = 4;
            Rectangle rectangle = new Rectangle(l, w);
            shape.Display();
            rectangle.Display();
        }
        
    }
    class Shape
    {
        public string name { get; set; }
        public int area { get; protected set; }
        public int perimeter { get; protected set; }

        public Shape()
        {
            name = "Faux Rectangle";
        }

        public void Display()
        {
            int a = CalculateArea();
            int p = CalculatePerimeter();
            System.Console.WriteLine($"Name: {name} Area: {a} Perimeter: {p}");
        }

        public virtual int CalculateArea()
        {
            // Provide implementation in derived classes
            return 0;
        }

        public virtual int CalculatePerimeter()
        {
            // Provide implementation in derived classes
            return 0;
        }
    }

    class Rectangle : Shape
    {
        public int length { get; set; }
        public int width { get; set; }

        public Rectangle(int Length, int Width)
        {
            name = "Rectangle";
            length = Length;
            width = Width;
            CalculateArea();
            CalculatePerimeter();
        }

        public override int CalculateArea()
        {
            area = length * width;
            return area;
        }

        public override int CalculatePerimeter()
        {
            perimeter = 2 * length + 2 * width;
            return perimeter;
        }
    }
}
