﻿using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SORTING ALGORITHMS");
            int[] array = new int[10] { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10 };
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

            //merge
            int[] test3 = new int[array.Length];
            Array.Copy(array,test3,array.Length);
            start = DateTime.Now;
            Console.WriteLine("Merge sort: [{0}] in {1}s", string.Join(", ", Merge.Sort(test3)), (DateTime.Now - start).TotalSeconds);

            Console.WriteLine("\nThe real array: [{0}]", string.Join(", ",array));
        }
    }
}
