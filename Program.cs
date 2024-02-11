using System.Drawing;
using StunningPancake;

namespace StunningPancake
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            Sword basicSword = new Sword(Materials.iron, Gemstones.none, 5, 2);
            Sword variationSword1 = basicSword with {gem = Gemstones.amber};
            Sword variationSword2 = basicSword with {material = Materials.binarium, gem = Gemstones.bitstone, length = 1000};
            System.Console.WriteLine(basicSword);
            System.Console.WriteLine(variationSword1);
            System.Console.WriteLine(variationSword2);
        }
        
    }
    public enum Materials
    {
        wood,
        bronze,
        iron,
        steel,
        binarium
    }
    public enum Gemstones
    {
        emerald,
        amber,
        sapphire,
        diamond,
        bitstone,
        none
    }
    public record Sword (Materials material, Gemstones gem, int length, int crossguard);
}