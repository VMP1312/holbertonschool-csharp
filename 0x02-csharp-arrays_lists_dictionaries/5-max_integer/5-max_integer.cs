using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }

        int cnt = 1;
        int max = myList[0];

        while (cnt < myList.Count)
        {
            if (myList[cnt] > max)
                max = myList[cnt];

            cnt++;
        }
        return max;
    } 
}
