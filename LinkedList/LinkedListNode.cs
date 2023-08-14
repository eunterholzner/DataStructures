namespace LinkedList;

public class LinkedListNode<T>
{   
    public T Value { get; }
    public LinkedListNode<T>? NextNode { get; set; }

    public LinkedListNode(T value) 
    {
        Value = value;
    }

    public void AddNode(LinkedListNode<T> node) {
        if (NextNode == null)
            NextNode = node;
        else 
            NextNode.AddNode(node);
    }
}