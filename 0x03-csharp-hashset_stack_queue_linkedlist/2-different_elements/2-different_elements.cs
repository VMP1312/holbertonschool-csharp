﻿using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> Nlist = new List<int>();
        foreach (int n in list1)
        {
            if (list2.Contains(n) == false)
                Nlist.Add(n);
        }

        foreach (int n in list2)
        {
            if (list1.Contains(n) == false)
                Nlist.Add(n);
        }
        Nlist.Sort();
        return Nlist;
    }
}