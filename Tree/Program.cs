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
                Console.WriteLine("Preorder");
                tree.Preorder(tree.Root,0);
                Console.WriteLine("Postorder");
                tree.Postorder(tree.Root,0);
                Console.WriteLine("Inorder");
                tree.Inorder(tree.Root,0);

                //Breadth first
                Console.WriteLine("Using given level");
                DateTime startTime = DateTime.Now;
                tree.LevelOrder(tree.Root);
                Console.Write($" in {(DateTime.Now - startTime).TotalSeconds}s\n");

                Console.WriteLine("Using queue");
                startTime = DateTime.Now;
                tree.LevelOrderWithQueue(tree.Root);
                Console.Write($" in {(DateTime.Now - startTime).TotalSeconds}s\n");
        }
    }
}
