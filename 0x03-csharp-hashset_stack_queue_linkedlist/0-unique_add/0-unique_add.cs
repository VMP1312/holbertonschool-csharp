using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        List<int> NList = new List<int>();
        int add = 0;
        int cnt = 0;

        foreach (int n in myList)
        {
            if (NList.Contains(n) == false)
                NList.Add(n);
        }

        for (; cnt < NList.Count; cnt++)
            add += NList[cnt];

        return add;
    }
}
