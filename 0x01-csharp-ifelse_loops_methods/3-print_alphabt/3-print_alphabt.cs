using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            for (c = 'a'; c <= 'z'; c++) 
            {
                if (c == 'e' || c == 'q')
                {
                    continue;
                }
                else
                {
                    Console.Write("{0}", c);
                }
            }
        }
    }
}
