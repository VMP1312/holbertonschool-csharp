using System;

/// <summary>Class operations with matrices</summary>
class MatrixMath
{
    /// <summary>Method that transposes a matrix</summary>
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix.Length == 0)
            return matrix;

        int rws = matrix.GetLength(0);
        int cls = matrix.GetLength(1);

        double[,] res = new double[cls, rws];

        for (int x = 0; x < rws; x++)
        {
            for (int y = 0; y < cls; y++)
                res[y, x] = matrix[x, y];
        }
        return res;
    }
}