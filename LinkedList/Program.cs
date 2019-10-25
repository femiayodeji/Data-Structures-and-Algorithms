using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINKED LIST");

            LinkedList<int> list = new LinkedList<int>();
            //addition
            list.Add(1);
            Node<int> n = list.Add(5);
            list.Add(12);
            list.Add(15);
            Console.WriteLine($"Addition: {list}");

            //insertion
            list.Insert(n,27);
            Console.WriteLine($"Insertion: {list}");

            //search
            var search = list.Find(12);
            Console.WriteLine($"({search.Position} : {search.Item.Value})");
            search = list.Find(6);
            Console.WriteLine($"({search.Position} : {search.Item.Value})");

            //deletion
            Console.WriteLine($"Delete 3: {list.Delete(3)}");
            Console.WriteLine($"Delete 15: {list.Delete(15)}");
            Console.WriteLine(list);
            Console.WriteLine($"Delete after 5: {list.DeleteAfter(n)}");
            Console.WriteLine(list);
        }
    }
}
