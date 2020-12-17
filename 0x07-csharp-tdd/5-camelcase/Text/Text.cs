using System;

namespace Text
{
    /// <summary> Str Class</summary>
    public class Str
    {
        /// <summary> How many words are in a string</summary>
        public static int CamelCase(string s)
        {
            if (s == "" || s == null)
                return 0;

            int cnt = 0;

            for (int mv = 0; mv < s.Length; mv++)
            {
                if (Char.IsUpper(s[mv]))
                    cnt++;
            }
            return cnt + 1;
        }
    }
}
