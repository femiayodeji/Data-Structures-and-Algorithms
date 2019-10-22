public class Node{
    public int data;
    public Node left, right;

    public Node(int item){
        data = item;
        left = right = null;
    }
}

public class BinaryTree{
    public Node root;

    public bool BST{
        get {
            return isBSTUtil(root, int.MinValue, int.MaxValue);
        }
    }

    public bool isBSTUtil(Node node, int min, int max){
        if(node == null) return true;

        //min/max constraints
        if(node.data < min || node.data > max) return false;

        return (isBSTUtil(node.left, min, node.data - 1) && isBSTUtil(node.right, node.data + 1, max));
    }
}