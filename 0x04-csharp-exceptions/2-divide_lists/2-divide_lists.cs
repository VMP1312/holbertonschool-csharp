using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        int div = 0;
        List<int> NList = new List<int>();

        for (int mv = 0; mv < listLength; mv++)
        {
            try
            {
                div = list1[mv]/list2[mv];
                NList.Add(div);
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                div = 0;
                NList.Add(div);
            }

            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");  
            }
        }
        return NList;
    }
}
