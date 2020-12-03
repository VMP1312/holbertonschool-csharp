using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int suma = 0;
        foreach (int n in myLList)
            suma += n; 

        return suma;
    }
}
