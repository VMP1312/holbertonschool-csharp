using System;
using System.Collections.Generic;
using System.Linq;
class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string name = "0";
        if(myList.Count == 0)
            return "None";


        else
        {
        foreach (KeyValuePair<string, int> elem in myList.OrderByDescending(key => key.Value))
            {
                    name = elem.Key;
                    return(name);
            }
        }
        return(name);
    }
}
