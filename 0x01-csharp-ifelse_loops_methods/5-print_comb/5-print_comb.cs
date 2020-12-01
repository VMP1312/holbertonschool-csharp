using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            for (num = 0; num < 99; num++) {
                Console.Write("{0:D2}, ", num);
            }
            Console.Write("99\n");
        }
    }
}
