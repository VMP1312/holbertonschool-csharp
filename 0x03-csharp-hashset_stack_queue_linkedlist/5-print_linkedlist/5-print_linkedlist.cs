using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            LinkedList<int> NList = new LinkedList<int>();
            return NList;
        }

        else
        {
            int[] n = new int[size];
            for (int cnt = 0; cnt < size; cnt++)
            {
                n[cnt] = cnt;
                Console.WriteLine(n[cnt]);
            }
            LinkedList<int> NList = new LinkedList<int>(n);  
            return NList;
        }
    }
}
