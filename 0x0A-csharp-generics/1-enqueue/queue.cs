﻿using System;

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
}
