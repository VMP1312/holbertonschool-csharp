﻿using System;

/// <summary>Calculates dot product of either two 2D or two 3D vectors</summary>
class VectorMath
{
    /// <summary>Calculates dot product of either two 2D or two 3D vectors</summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length)
            return -1;

        if (vector1.Length >= 2 && vector2.Length >= 2 && vector1.Length <= 3 && vector2.Length <= 3)
        {
            double dotP = 0;
            for (int mv = 0; mv < vector1.Length; mv++)
            {
                double mult = vector1[mv] * vector2[mv];
                dotP = dotP + mult;
            }
            return dotP;
        }

        return -1;
    }
}
