using System;

/// <summary>Multiplies two matrices and returns the resulting matrix</summary>
class MatrixMath
{
    /// <summary>Multiplies two matrices and returns the resulting matrix</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] err = {{-1}};
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return err;

        double[,] NMatrix = new double[rows, col2];
        int rows = matrix1.GetLength(0);
        int col1 = matrix1.GetLength(1);
        int col2 = matrix2.GetLength(1);

        for (int x = 0; x < rows; x++)
        {
            for (int y = 0; y < cols2; y++)
            {
                double putter = 0; 
                for (int mv = 0; mv < col1; mv++)
                    putter = putter + matrix1[x, mv] * matrix2[mv, y];

                NMatrix[x, y] = putter;
            }
        }
        return NMatrix;
    }
}
