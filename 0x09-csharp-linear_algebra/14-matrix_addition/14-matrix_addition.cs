using System;

/// <summary>Adds two matrices and returns the resulting matrix</summary>
class MatrixMath
{
    /// <summary>Adds two matrices and returns the resulting matrix</summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] err = { { -1 } };

        if (matrix1.Length != matrix2.Length)
            return err;

        if (matrix1.GetLength(0) >= 2 && matrix2.GetLength(0) >= 2 && matrix1.GetLength(0) <= 3 && matrix2.GetLength(0) <= 3)
        {
            for (int x = 0; x < matrix1.GetLength(0); x++)
            {
                for (int y = 0; y < matrix2.GetLength(1); y++)
                    matrix1[x, y] = matrix1[x, y] + matrix2[x, y];
            }

            return matrix1;
        }

        return err;
    }
}
