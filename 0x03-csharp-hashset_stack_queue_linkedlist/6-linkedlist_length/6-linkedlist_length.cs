using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myList)
    {
        int cnt = 0;
        foreach (int index in myList)
            cnt++;

        return cnt;
    }
}
