using System;

namespace SearchingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SEARCHING ALGORITHMS");
            int[] testArray = new int[]{ -34, -21, -18, -12, -3, -1, 0, 3, 8, 12, 23 };
            Console.WriteLine("Test array: [{0}]", string.Join(", ", testArray));

            int testItem = -12;
            PrintSearchInformation(testItem, testArray);

            testItem = 0;
            PrintSearchInformation(testItem, testArray);

            testItem = 23;
            PrintSearchInformation(testItem, testArray);

            testItem = 2;
            PrintSearchInformation(testItem, testArray);            
        }

        public static void PrintSearchInformation(int testItem, int[] testArray){
            Console.WriteLine($"Searching for {testItem}: \n\tLinear {LinearSearchExtension.LinearSearch(testArray, testItem)}, \n\tBinary Search {BinarySearchExtension.BinarySearch(testArray, testItem)}, \n\tBinary Iterative {BinarySearchIterativeExtension.BinarySearchIterative(testArray, testItem)}");
        }
    }
}
