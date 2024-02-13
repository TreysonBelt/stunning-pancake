using System.Drawing;
using StunningPancake;

namespace StunningPancake
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            double num = 10;
            double weight = 25;
            double volume = 20.1;
            Pack pack = new Pack(num, weight, volume);
            bool end = true;
            while (end)
            {
                System.Console.Write("What would you like to do? ");
                string input = Console.ReadLine();
                if (input == "add sword")
                {
                    Sword sword = new Sword();
                    pack.Add(sword);
                }
                else if (input == "add arrow")
                {
                    Arrow arrow = new Arrow();
                    pack.Add(arrow);
                }
                else if (input == "add bow")
                {
                    Bow bow = new Bow();
                    pack.Add(bow);
                }
                else if (input == "add rope")
                {
                    Rope rope = new Rope();
                    pack.Add(rope);
                }
                else if (input == "add water")
                {
                    Water water = new Water();
                    pack.Add(water);
                }
                else if (input == "add food")
                {
                    Food food = new Food();
                    pack.Add(food);
                }
                else if (input == "end")
                {
                    end = false;
                }
                else if (input =="check pack")
                {
                    pack.Display();
                }
                else if (input == "menu")
                {
                    System.Console.WriteLine("You can add a sword, arrow, bow, rope, water, food, or check your pack. input end if you wish to end simulation.");
                }
                else
                {
                    System.Console.WriteLine("please insert an accepted command.");
                }
            }
        }
    }
    class InventoryItem
    {
        public double weight {get; protected set;}
        public double volume {get; protected set;}
        public InventoryItem()
        {
            weight = 0.01;
            volume = 0.01;
        }
        public InventoryItem(double Weight, double Volume)
        {
            weight = Weight;
            volume = Volume;
        }
    }
    class Arrow : InventoryItem
    {
        public Arrow()
        {
            weight = 0.01;
            volume = 0.05;
        }
    }
    class Bow : InventoryItem
    {
        public Bow()
        {
            weight = 1;
            volume = 4;
        }
    }
    class Rope : InventoryItem
    {
        public Rope()
        {
            weight = 1;
            volume = 1.5;
        }
    }
    class Water : InventoryItem
    {
        public Water()
        {
            weight = 2;
            volume = 3;
        }
    }
    class Food : InventoryItem
    {
        public Food()
        {
            weight = 1;
            volume = 0.5;
        }
    }
    class Sword : InventoryItem
    {
        public Sword()
        {
            weight = 5;
            volume = 3;
        }
    }
    class Pack
    {
        public double numMax {get;}
        public double weightMax {get;}
        public double volumeMax {get;}
        private double num;
        private double Weight;
        private double Volume;
        bool isPackFull = false;
        List<InventoryItem> packList = new List<InventoryItem>();
        public Pack(double Num, double Weight, double Volume)
        {
            numMax = Num;
            weightMax = Weight;
            volumeMax = Volume;
        }
        public bool Add(InventoryItem item)
        {
            num ++;
            Weight = Weight + item.weight;
            Volume = Volume + item.volume;
            if ((num >= numMax) || (Weight >= weightMax) || (Volume == volumeMax))
            {
                num = num - 1;
                Weight = Weight - item.weight;
                Volume = Volume - item.volume;
                System.Console.WriteLine("Exceeds pack requirements.");
                isPackFull = false;
            }
            else
            {
                packList.Add(item);
                System.Console.WriteLine("Item inserted.");
                isPackFull = true;
            }
            return isPackFull;
        }
        public void Display()
        {
            foreach (InventoryItem item in packList)
            {
                System.Console.WriteLine($"Item: {item} weight: {item.weight} volume: {item.volume}");
            }
            System.Console.WriteLine($"current weight and volume free: {(weightMax - Weight)}, {(volumeMax - Volume)}");
        }
    }
}
