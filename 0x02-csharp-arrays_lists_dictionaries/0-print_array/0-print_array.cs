using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        int i;
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] array = new int[size];

        if (size == 0)
            Console.WriteLine();

        for (i = 0; i < size; i++)
        {
            array[i] = i;

            if (i < size - 1)
                Console.Write(array[i] + " ");

            else
                Console.WriteLine(array[i]);
        }
        return array;
    }
}
