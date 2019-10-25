using System;

public class Node<T> {
    public T Value {get;set;}
    public Node<T> Next {get;set;}
}
public class Stack<T>{
    public Node<T> Head {get;set;}

    public void Push(T value){
        Node<T> newNode = new Node<T> {Value = value, Next = null};
        if(Head == null){
            Head = newNode;
            return;
        }
        newNode.Next = Head;
        Head = newNode;
    }

    public T Pop(){
        if(Head == null) throw
            new InvalidOperationException("The stack is empty");
        var result = Head.Value;
        Head = Head.Next;
        return result;
    }

    public T Peek(){
        if(Head == null) throw
            new InvalidOperationException("The stack is empty");
        return Head.Value;
    }

    public override string ToString(){
        string output = "(";
        var node = Head;
        while (node != null)
        {
            output += node.Value.ToString() + ")";
            node = node.Next;
        }
        return output;
    }
}