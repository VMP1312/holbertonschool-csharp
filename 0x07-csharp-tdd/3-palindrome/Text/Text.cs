using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Text
{
    /// <summary> String Class</summary>
    public class Str
    {
        /// <summary> Check if is palindrome</summary>
        public static bool IsPalindrome(string s)
        {
            if (str == "")
            {
                return true;
            }
            var newS = new StringBuilder();
            foreach (char c in str)
            {
                if ((!char.IsPunctuation(c)) && c != ' ')
                    newS.Append(c);
            }
            string str2 = newS.ToString();
            str2 = str2.ToLower();
            char[] arr = str2.ToCharArray();
            Array.Reverse(arr);
            for (int cnt = 0; cnt < str2.Length;cnti++)
            {
                if (s2[cnt] == arr[cnt])
                    continue;

                else
                    return false;
            }
            return true;
        }
    }
}
