using System;


class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int width = myMatrix.GetLength(0);
        int height = myMatrix.GetLength(1);
        int[,] NMatrix = new int[width,height];
        double square = 0;

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                square = Math.Pow(myMatrix[x, y], 2);
                NMatrix[x, y] = (int)square;
            }
        } 
        return NMatrix;
    }
}
