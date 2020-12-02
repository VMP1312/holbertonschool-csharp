using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt;
            for (cnt = 1; cnt <= 99; cnt++) {
                if (cnt % 3 == 0 && cnt % 5 == 0) 
                    Console.Write("FizzBuzz ");

                else if (cnt % 3 == 0)
                    Console.Write("Fizz ");

                else if (cnt % 5 == 0)
                    Console.Write("Buzz ");

                else
                    Console.Write("{0} ", cnt);
            }
            Console.WriteLine("Buzz");
        }
    }
}
