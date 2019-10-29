using System;

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
}