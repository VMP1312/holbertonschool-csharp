using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int cnt = 0;
        LinkedListNode<int> mv;
        mv = myLList.First;

        while (mv != null)
        {
            if (cnt == index)
            {
                myLList.Remove(mv);
                break;
            }
            cnt++;
            mv = mv.Next;
        }
    }
}
