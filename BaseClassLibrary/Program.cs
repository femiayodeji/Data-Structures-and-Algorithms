using System;

namespace BaseClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle a = new Rectangle(1,2);
            Rectangle b = new Rectangle(2,4);

            Console.WriteLine($"Rectangle a area: {a.GetArea()}");
            Console.WriteLine($"Rectangle b area: {b.GetArea()}");
            Console.WriteLine();
            Console.WriteLine($"Number of angles in a rectangle is {Rectangle.GetNumberOfAngle()}");
        }
    }
}
