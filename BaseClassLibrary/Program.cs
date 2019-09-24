using System;

namespace BaseClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OOP Basic");
            Rectangle a = new Rectangle(1,2);
            Rectangle b = new Rectangle(2,4);

            Console.WriteLine($"Rectangle a area: {a.GetArea()}");
            Console.WriteLine($"Rectangle b area: {b.GetArea()}");
            Console.WriteLine();
            Console.WriteLine($"Number of angles in a rectangle is {Rectangle.GetNumberOfAngle()}");

            Console.WriteLine("Generic Class");

            Pair<int> x = new Pair<int>(1,2);
            Pair<string> y = new Pair<string>("Hello", "World");

            Console.WriteLine($"Pair of integer: {x.First} and {x.Second}");
            Console.WriteLine($"Pair of string: {y.First} and {y.Second}");
        }
    }
}
