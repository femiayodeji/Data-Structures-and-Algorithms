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

            //transversal
                //Depth first            
                Console.WriteLine("Preorder");
                tree.Preorder(tree.Root,0);
                Console.WriteLine("Postorder");
                tree.Postorder(tree.Root,0);
                Console.WriteLine("Inorder");
                tree.Inorder(tree.Root,0);
        }
    }
}
