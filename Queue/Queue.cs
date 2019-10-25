using System;

public class Node<T>{
    public T Value {get;set;}
    public Node<T> Next {get; set;}
}

public class Queue<T> {
    public Node<T> Head {get;set;}
    public Node<T> Tail {get;set;}

    public void Enqueue(T value){
        Node<T> newNode = new Node<T> {Value = value, Next = null};
        if(Tail == null){
            Tail = newNode;
            Head = Tail;
            return;
        }
        Tail.Next = newNode;
        Tail = newNode;
    }

    public T Dequeue(){
        if(Head == null) throw
            new InvalidOperationException("The queue is empty");
        var result = Head.Value;
        Head = Head.Next;
        return result;
    }

    public T Peek(){
        if(Head == null) throw
            new InvalidOperationException("The queue is empty");
        return Head.Value;
    }

    public override string ToString(){
        string output = "";
        var node = Head;
        while(node != null){
            output += node.Value + " <- ";
            node = node.Next;
        }
        return output;
    }
}