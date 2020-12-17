  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text
{
    /// <summary> Str Class</summary>
    public class Str
    {
        /// <summary> Returns the index of the first non-repeating character of a string</summary>
        public static int UniqueChar(string s)
        {
            string s1 = "";
            string s2 = "";

            if (s == "" || s == null)
                return -1;

            int check = 0;

            for (int cnt = 0; cnt < s.Length; cnt++)
            {
                s1 = s.Substring(cnt, 1);
                int idx = 0;

                for (int mv = 0; mv < s.Length; mv++)
                {
                    s2 = s.Substring(mv, 1);

                    if ((s1 == s2) && (cnt != mv))
                        continue;

                    else if ((s1 != s2) && (cnt != mv))
                    {
                        idx++;

                        if (idx == s.Length - 1 && check < idx)
                        {
                            check = idx;
                            return(cnt);
                        }
                    }
                }
            }
            return -1; 
        }
    }
}
