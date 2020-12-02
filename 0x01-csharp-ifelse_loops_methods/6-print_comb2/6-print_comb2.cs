using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
        {
            int i;
            int j;

            for (i = 0; i <= 9 ; i++)
            {
                for (j = 1; j <= 9; j++)
                {
                    if (i < j)
                    {
                        Console.Write("{0}{1}, ", i, j);
                    }
                }
            }
            Console.WriteLine("89");
        }
        }
    }
}
