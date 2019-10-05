using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]{1,2,3};
            Console.WriteLine("[{0}]",string.Join(",",array));
            array[1] = 10;
            Console.WriteLine("[{0}]",string.Join(",",array));

            try{
                array[3] = 10;
            }
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }

            // A multi-dimensional array.2D space,
            // a table in this case
            int[,] a = {
                {1,2,3},
                {4,5,6}
            };
            Console.WriteLine(
                $"A multi-dimensional array length: {a.Length}"
            );

            // A jagged array. It's an array of arrays, so you 
            // need to intialized nested arrays afterwards
            int[][] b = {
                new int[] {1,2,3},
                new int[] {10,20,30,40,50},
                new int[] {5,6}
            };

            Console.WriteLine($"The jagged array length: {b.Length}");
            Console.WriteLine($"The nested array lenght: {b[1].Length}");
        }
    }
}
