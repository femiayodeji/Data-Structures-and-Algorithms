using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SORTING ALGORITHMS");
            int[] array = new int[10] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };
            DateTime start;
            Console.WriteLine("The real array: [{0}]\n", string.Join(", ",array));

            //bubble
            int[] test1 = new int[array.Length];
            Array.Copy(array,test1,array.Length);
            start = DateTime.Now;
            Console.WriteLine("Bubble sort: [{0}] in {1}s", string.Join(", ", Bubble.Sort(test1)), (DateTime.Now - start).TotalSeconds);

            //selection
            int[] test2 = new int[array.Length];
            Array.Copy(array,test2,array.Length);
            start = DateTime.Now;
            Console.WriteLine("Selection sort: [{0}] in {1}s", string.Join(", ", Selection.Sort(test2)), (DateTime.Now - start).TotalSeconds);

            Console.WriteLine("\nThe real array: [{0}]", string.Join(", ",array));
        }
    }
}
