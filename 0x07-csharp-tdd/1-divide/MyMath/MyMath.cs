using System;

namespace MyMath
{
    /// <summary> Class Matrix</summary>
    public class Matrix
    {
        /// <summary> Divides a matrix by num</summary>
        public static int[,] Divide(int[,] matrix, int num){

            if (matrix == null)
                return null;

            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }

            int width = matrix.GetLength(0);
            int height = matrix.GetLength(1);
            int[,] NMatrix = new int[width,height];

            for (int mvx = 0; mvx < width; mvx++) 
            {
                for (int mvy = 0; mvy < height; mvy++) 
                {
                    int res = (matrix[mvx, mvy] / num);
                    NMatrix[mvx, mvy] = res;
                }
            }
                return NMatrix;
        }
    }
}
