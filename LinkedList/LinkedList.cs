using System.Collections;

namespace LinkedList;

public class LinkedList<T> : IEnumerable
{
    public LinkedListNode<T>? Tail { get; private set; }

    public LinkedList() {
        Tail = null;
    }

    public void AddElementToList(T element) {
        LinkedListNode<T> node = new(element);
        
        if (Tail != null)
            Tail.AddNode(node);
        else
            Tail = node;
    }

    public void RemoveFirstFromList(T element) {
        LinkedListNode<T>? currentNode = Tail;

        if (Tail != null && Tail.Value!.Equals(element)) {
            Tail = Tail.NextNode;
            return;
        }

        while (currentNode != null) {
            if (currentNode.NextNode != null && currentNode.NextNode.Value!.Equals(element)) {
                currentNode.NextNode = currentNode.NextNode.NextNode;
                return;
            }
            else
                currentNode = currentNode.NextNode;
        }
    }

    public void RemoveFirst() {
        if (Tail != null)
            Tail = Tail.NextNode;
    }

    public void RemoveLast() {
        LinkedListNode<T>? currentNode = Tail;

        if (Tail == null)
            return;

        if (Tail.NextNode == null) {
                Tail = null;
                return;
        }

        while (currentNode != null) {
            if (currentNode!.NextNode.NextNode == null) 
                currentNode.NextNode = null;

            currentNode = currentNode!.NextNode;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new LinkedListEnumerator<T>(Tail!);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new LinkedListEnumerator<T>(Tail!);
    }
}