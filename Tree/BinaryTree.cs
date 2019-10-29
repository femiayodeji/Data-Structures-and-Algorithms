using System;
using System.Collections.Generic;

public class Node{
    public int Value {get;set;}
    public Node Left {get;set;}
    public Node Right {get;set;}     

    public Node(){
    }
    public Node(int value){
        Value = value;
    }
}

public class BinaryTree {
    public Node Root {get;set;}
    
    public void Add(int value){
        Node newNode = new Node(value);
        if(Root == null){
            Root = newNode;
            return;
        }
        Insert(Root, newNode);

    }
    public void Insert(Node node, Node newNode){
        if(node == null) node = newNode;
        if(newNode.Value < node.Value){
            if(node.Left == null){
                node.Left = newNode;                
            }
            else{
                Insert(node.Left, newNode);
            }
        }
        else{
            if(node.Right == null){
                node.Right = newNode;
            }
            else{
                Insert(node.Right, newNode);
            }
        }
    }

    public void Preorder(Node node, int level){
        //root-left-right
        if(node == null) return;
        String separator = new String('_',level);
        Console.WriteLine($"{separator}{node.Value}");
        Preorder(node.Left, level + 1);
        Preorder(node.Right, level + 1);
    }

    public void Postorder(Node node, int level){
        //left-right-root
        if(node == null) return;
        Postorder(node.Left,level + 1);
        Postorder(node.Right,level + 1);        
        String separator = new String('_',level);
        Console.WriteLine($"{separator}{node.Value}");
    }

    public void Inorder(Node node, int level){
        //left-root-right
        if(node == null) return;
        Inorder(node.Left,level + 1);
        String separator = new String('_',level);
        Console.WriteLine($"{separator}{node.Value}");
        Inorder(node.Right,level + 1);
    }

    public void LevelOrder(Node tree){
        int height = Height(tree);
        for(int i = 1; i <= height; i++){
            String separator = new String('_', height-i);
            Console.Write(separator);
            GivenLevel(tree,i);
            Console.Write("\n");
        }
    }
    public int Height(Node root){
        if(root == null) return 0;
        int lHeight = Height(root.Left);
        int rHeight = Height(root.Right);
        if(lHeight > rHeight){
            return lHeight + 1;
        }
        else{
            return rHeight + 1;
        }
    }

    public void GivenLevel(Node node, int level){
        if(node == null) return;
        if(level == 1){
            Console.Write(node.Value + " ");
        }
        else if(level > 1){
            GivenLevel(node.Left, level - 1);
            GivenLevel(node.Right, level - 1);
        }
    }

    public void LevelOrderWithQueue(Node tree){
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(tree);
        while(queue.Count != 0){
            Node tempNode = queue.Dequeue();
            Console.Write(tempNode.Value + " ");
            if(tempNode.Left != null) queue.Enqueue(tempNode.Left);
            if(tempNode.Right != null) queue.Enqueue(tempNode.Right);
        }
    }
}