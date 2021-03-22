using System;

/// <summary>Queue Generic class </summary>

class Queue<T>
{
    /// <summary>returns type of the object</summary>
    public Type CheckType()
    {
        return typeof(T); 
    }

    /// <summary>Linker</summary>
    public class Node 
    {
        public T value;
        public Node next = null;

        public Node(T value)
        {
            this.value = value;
        }
    }
        
    public Node head;
    public Node tail;
    public int count;

    /// <summary>Creates a node</summary>
    public void Enqueue(T value) 
    {
        Node node = new Node(value);

        if (head == null)
            head = node;
        else
            tail.next = node;
        tail = node;
        count ++;
    }

    /// <summary>Returns count</summary>
    public int Count()
    {
        return count;
    }

    /// <summary>Removes the first node</summary>
    public T Dequeue()
    {
        if (head != null)
        {
            T node = head.value;
            head = head.next;
            count --;
            return node;
        }
        else
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
    }

    ///<summary>Returns the value of the first node</summary>
    public T Peek()
    {
        if (head != null)
            return head.value;
        else
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

    }
    public void Print()
    {
         if (head != null)
        {
            while(head != null)
            {
                Console.WriteLine(head.value);
                head = head.next;
            }
         }
        else
            Console.WriteLine("Queue is empty");
    }
}
