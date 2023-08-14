namespace LinkedList;

public class LinkedListEnumerator<T> : IEnumerator<T>
{   
    int index;
    LinkedListNode<T>? tail;
    LinkedListNode<T>? currentNode;
    
    public LinkedListEnumerator(LinkedListNode<T>? linkedListTail) {
        index = -1;
        tail = linkedListTail;
        currentNode = null;
    }

    public object Current => currentNode;

    T? IEnumerator<T>.Current => currentNode.Value;

    public void Dispose()
    {
        currentNode = null;
        tail = null;
        index = -1;
    }

    public bool MoveNext()
    {  
        if (tail == null)
            return false;

        if (currentNode == null) {
            currentNode = tail;
            index++;
            return true;
        }

        if (currentNode.NextNode != null) {
            currentNode = currentNode.NextNode;
            index++;
            return true;
        }
        else    
            return false;
    }

    public void Reset()
    {
        index = -1;
        currentNode = null!;
    }
}