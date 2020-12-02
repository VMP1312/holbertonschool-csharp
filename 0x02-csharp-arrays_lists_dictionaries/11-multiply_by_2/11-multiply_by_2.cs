using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> NDict = new Dictionary<string, int> ();

        foreach (KeyValuePair<string, int> value in myDict)
        {
            int NV = value.Value * 2;
            NDict.Add(value.Key, NV);
        }
        return NDict;
    }
}
