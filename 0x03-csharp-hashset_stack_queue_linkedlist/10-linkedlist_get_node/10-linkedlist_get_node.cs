using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int cnt = 0;

        foreach (int value in myLList)
        {
            if (cnt > myLList.Count)
                return 0;

            else
            {
                if (cnt == n)
                    return value;
            }

            cnt++;
        }
        return 0;
    }
}
