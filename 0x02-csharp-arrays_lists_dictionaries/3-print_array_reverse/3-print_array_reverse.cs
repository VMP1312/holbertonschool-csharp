using System;

class Array
{
    public static void Reverse(int[] array)
    {
        int cnt;
        if (array == null || array.Length == 0)
            Console.WriteLine();

        else
        {
            cnt = array.Length - 1;

            for (; cnt >= 0; cnt--)
            {
                if (cnt <= 1)
                    Console.WriteLine(array[cnt]);

                else
                    Console.Write(array[cnt] + " ");

            }
        }
    }
}
