using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        int cnt;
        List<bool> NList = new List<bool> ();

        for (cnt = 0; cnt < myList.Count; cnt++)
        {
            if (myList[cnt] % 2 != 0)
                NList.Add(false);

            else
                NList.Add(true);
        } 
        return NList;
    }
}
