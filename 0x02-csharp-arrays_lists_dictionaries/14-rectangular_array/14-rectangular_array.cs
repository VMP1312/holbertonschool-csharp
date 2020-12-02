using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[5, 5];
        array[2,2] = 1;
        for (int x = 0; x < 5; x++)
        {
            for (int y = 0; y < 5; y++)
            {
                if (y < 4)
                    Console.Write(array[x,y] + " ");

                else
                    Console.Write(array[x,y]);
            }
        Console.WriteLine();
        }
    }  
}
