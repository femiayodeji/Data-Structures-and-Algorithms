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
            Console.WriteLine("\tBubble sort: [{0}] in {1}s", string.Join(", ", Bubble.Sort(test1)), (DateTime.Now - start).TotalSeconds);

            //selection
            int[] test2 = new int[array.Length];
            Array.Copy(array,test2,array.Length);
            start = DateTime.Now;
            Console.WriteLine("\tSelection sort: [{0}] in {1}s", string.Join(", ", Selection.Sort(test2)), (DateTime.Now - start).TotalSeconds);

            //insetrtion
            int[] test3 = new int[array.Length];
            Array.Copy(array,test3,array.Length);
            start = DateTime.Now;
            Console.WriteLine("\tInsertion sort: [{0}] in {1}s", string.Join(", ", Insertion.Sort(test3)), (DateTime.Now - start).TotalSeconds);

            //merge
            int[] test4 = new int[array.Length];
            Array.Copy(array,test4,array.Length);
            start = DateTime.Now;
            Console.WriteLine("\tMerge sort: [{0}] in {1}s", string.Join(", ", Merge.Sort(test4)), (DateTime.Now - start).TotalSeconds);

            //quick
            int[] test5 = new int[array.Length];
            Array.Copy(array,test5,array.Length);
            start = DateTime.Now;
            Console.WriteLine("\tQuick sort: [{0}] in {1}s", string.Join(", ", Quick.Sort(test5)), (DateTime.Now - start).TotalSeconds);

            Console.WriteLine("\nThe real array: [{0}]", string.Join(", ",array));
        }
    }
}
