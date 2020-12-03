using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> NList = new List<int>();
        foreach (int n in list1)
        {
            if (list2.Contains(n))
                NList.Add(n);
        }
        NList.Sort();
        return NList;
    }
}
