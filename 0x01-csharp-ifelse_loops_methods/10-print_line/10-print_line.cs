using System;

class Line
{
    public static void PrintLine(int length)
    {
        int cnt;
        if (length <= 0)
            Console.Write("\n");
        else
        {
            for (cnt = 0; cnt <= length; cnt++)
                Console.Write("_");
            Console.WriteLine("");
        }
    }
}
