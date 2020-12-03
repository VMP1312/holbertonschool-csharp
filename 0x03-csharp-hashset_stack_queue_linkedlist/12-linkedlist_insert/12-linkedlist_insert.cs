using System;
using System.Collections.Generic;

    class LList
    {
        public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
        {
            LinkedListNode<int> mv = myLList.First;
            while(mv != null)
            {
                if(mv.Value < n)
                    mv = mv.Next;

                else
                    return(myLList.AddBefore(mv, n));

            }
            return(myLList.AddLast(n));  
        }
    }
