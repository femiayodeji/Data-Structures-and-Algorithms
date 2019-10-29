using System;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TREE - Binary");
            BinaryTree tree = new BinaryTree();
            tree.Add(5);
            tree.Add(7);
            tree.Add(2);
            tree.Add(1);
            tree.Add(6);
            tree.Add(3);

            //traversal
                //Depth first            
                Console.WriteLine("\nPreorder");
                tree.Preorder(tree.Root,0);
                Console.WriteLine("\nPostorder");
                tree.Postorder(tree.Root,0);
                Console.WriteLine("\nInorder");
                tree.Inorder(tree.Root,0);

                //Breadth first
                Console.WriteLine("\nUsing given level");
                DateTime startTime = DateTime.Now;
                tree.LevelOrder(tree.Root);
                Console.Write($" in {(DateTime.Now - startTime).TotalSeconds}s\n");

                Console.WriteLine("\nUsing queue");
                startTime = DateTime.Now;
                tree.LevelOrderWithQueue(tree.Root);
                Console.Write($" in {(DateTime.Now - startTime).TotalSeconds}s\n");

            //Search
            Console.WriteLine("\nSearching (Preorder)");
            string result = tree.Search(tree.Root, 6) != null ? "Found" : "Not found";
            Console.WriteLine($"Search for 6: {result}");
            result = tree.Search(tree.Root, 9) != null ? "Found" : "Not found";
            Console.WriteLine($"Search for 9: {result}");
        }
    }
}
