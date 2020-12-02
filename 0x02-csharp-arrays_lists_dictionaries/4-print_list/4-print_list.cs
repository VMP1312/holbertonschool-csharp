using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        int cnt;
        List<int> Nlist = new List<int>();
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        if (size == 0)
            Console.WriteLine();

        for (cnt = 0; cnt < size; cnt++)
        {
            Nlist.Add(cnt);

            if (cnt < size - 1)
                Console.Write(Nlist[cnt] + " ");

            else
                Console.WriteLine(Nlist[cnt]);
        }
        return Nlist;
    }
}
