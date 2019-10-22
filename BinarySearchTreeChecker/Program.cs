using System;
using System.Collections.Generic;

namespace BinarySearchTreeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BINARY SEARCH TREE CHECKER");

            List<BinaryTree> trees = new List<BinaryTree>();
            BinaryTree tree1 = new BinaryTree();
            tree1.root = new Node(4);
            tree1.root.left = new Node(2);
            tree1.root.right = new Node(5);
            tree1.root.left.left = new Node(1);
            tree1.root.left.right = new Node(3);
            trees.Add(tree1);

            BinaryTree tree2 = new BinaryTree();
            tree2.root = new Node(3);
            tree2.root.left = new Node(2);
            tree2.root.right = new Node(5);
            tree2.root.left.left = new Node(1);
            tree2.root.left.right = new Node(4);
            trees.Add(tree2);

            foreach(BinaryTree tree in trees){
                int num = trees.IndexOf(tree)+1;
                if(tree.BST){
                    Console.WriteLine($"Tree {num} Is BST");
                }
                else{
                    Console.WriteLine($"Tree {num} Is not BST");
                }
            }

        }
    }
}
