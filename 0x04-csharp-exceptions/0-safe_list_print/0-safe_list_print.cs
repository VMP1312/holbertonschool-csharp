using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int cnt = 0;
        try 
        {
            for (int mv = 0; mv < n; mv++)
            {
                Console.WriteLine(myList[mv]);
                cnt++;
            }
        }
        catch
        {

        }
        return cnt;
    }
}
