using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        if (myLList.Contains(value) == false)
            return -1;

        int index = 0;

        foreach (int cnt in myLList)
        {
            if (cnt == value)
                return index;

            index++;
        }
        return -1;
    }
}
