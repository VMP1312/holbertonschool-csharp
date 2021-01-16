using System;

/// <summary>Rotate Matrix</summary>
class MatrixMath
{
    /// <summary>Multiply matrix</summary>
    public static double[,] Multi(double[,] matrix1, double[,] matrix2)
    {
        double[,] err = {{-1}};
    
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return err;

        int rws1 = matrix1.GetLength(0);
        int cls1 = matrix1.GetLength(1);
        int cls2 = matrix2.GetLength(1);
        double[,] newMatrix = new double[rws1, cols2];

        for (int x = 0; x < rws1; x++)
        {
            for (int y = 0; y < cls2; y++)
            {
                double n = 0; 
                for (int z = 0; z < cls1; z++)
                    n = n + Math.Round(matrix1[x, z] * matrix2[z, y]);

                newMatrix[x, y] = n;
            }
        }
        return newMatrix;
    }
    
    /// <summary>Rotate Matrix</summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double Cos = Math.Cos(angle);
        double Sin = Math.Sin(angle);
        double[,] cosSin = 
            {
                {Cos, -Sin}, 
                {Sin, Cos}
            };
        double[,] newMatrix = new double[matrix.GetLength(0), matrix.GetLength(1)];
        double[,] err = {{-1}};

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return err;

        newMatrix = Multi(cosSin, matrix);
        return newMatrix;
    }
}
