using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        List<int> newList = new List<int>();
        int add = 0;
        int cnt = 0;

        foreach (int n in myList)
        {
            if (newList.Contains(n) == false)
                newList.Add(n);
        }
        for (; cnt < newList.Count; cnt++)
        {
            add += newList[cnt];
        }
        return add;
    }
}
