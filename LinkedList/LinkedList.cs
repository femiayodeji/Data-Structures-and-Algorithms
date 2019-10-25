public class Node<T>{
    public T Value {get; set;}
    public Node<T> Next {get;set;}
}

public class LinkedList<T>{
    public Node<T> Root {get;set;}

    public Node<T> Add(T value){
        Node<T> newNode = new Node<T> { Value = value, Next = null};
        if(Root == null) Root = newNode;
        else{
            Node<T> node = Root;
            while(node.Next != null){
                node = node.Next;
            }
            node.Next = newNode;
        }
        return newNode;
    }

    public Node<T> Insert(Node<T> node, T value){
        Node<T> newNode = new Node<T> {Value = value, Next = node.Next};
        node.Next = newNode;
        return newNode;
    }

    public (int Position, Node<T> Item) Find(T value){
        if(Root.Value.Equals(value)) return (0, Root);
        else{
            var current = Root.Next;
            int i = 1;
            while(current != null){
                if(current.Value.Equals(value)) return (i, current);
                current = current.Next;
                i++;
            }
            return (-1,new Node<T>());
        }
    }
    
    public bool Delete(T value){
        if(Root.Value.Equals(value)){
            Root = Root.Next;
            return true;
        }
        else{
            var previous = Root;
            var current = Root.Next;
            while(current != null){
                if(current.Value.Equals(value)){
                    previous.Next = current.Next;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
        }
        return false;
    }

    public bool DeleteAfter(Node<T> node){
        var nextNode = node.Next;
        if(nextNode == null) return false;
        node.Next = nextNode.Next;
        return true;
    }

    public override string ToString(){
        Node<T> node = Root;
        string output = node.Value.ToString();
        while(node.Next != null){
            output += " -> " + node.Next.Value.ToString();
            node = node.Next;
        }
        return output;
    }
}