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
            if (s == "")
                return true;

            var NewStr = new StringBuilder();
            foreach (char c in s)
            {
                if ((!char.IsPunctuation(c)) && c != ' ')
                    NewStr.Append(c);
            }

            string s2 = NewStr.ToString();
            s2 = s2.ToLower();
            char[] arr = s2.ToCharArray();
            Array.Reverse(arr);

            for (int cnt = 0; cnt < s2.Length; cnt++)
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
