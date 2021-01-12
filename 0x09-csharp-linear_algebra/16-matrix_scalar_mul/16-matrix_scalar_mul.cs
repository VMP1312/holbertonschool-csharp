
using System;

/// <summary>Multiplies a matrix and a scalar and returns the resulting matrix</summary>
class MatrixMath
{
    /// <summary>Multiplies a matrix and a scalar and returns the resulting matrix</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] err = { { -1 } };
        if (matrix.GetLength(0) >= 2 && matrix.GetLength(0) <= 3)
        {
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                    matrix[x, y] = matrix[x, y] * scalar;
            }
            return matrix;
        }

        return err;
    }
}
