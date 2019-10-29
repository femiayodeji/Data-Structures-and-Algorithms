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
            tree.Preorder(tree.Root,0);
        }
    }
}
