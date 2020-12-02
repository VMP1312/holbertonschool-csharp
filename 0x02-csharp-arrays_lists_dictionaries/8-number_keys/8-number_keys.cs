using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int cnt = 0;
        foreach (KeyValuePair<string, string> keys in myDict) 
        {
            cnt++;
        }
        return cnt;
    }
}
