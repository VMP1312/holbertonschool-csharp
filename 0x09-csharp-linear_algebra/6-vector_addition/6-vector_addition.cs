using System;

/// <summary>Adds two vectors</summary>
class VectorMath
{
    /// <summary>Adds two vectors</summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] err = {-1};

        if (vector1.Length < 2 || vector2.Length < 2 || vector1.Length > 3 || vector2.Length > 3)
            return err;

        if (vector1.Length != vector2.Length)
            return err;

        double[] sumVec = new double[vector1.Length];
        
        for (int mv = 0; mv < vector1.Length; mv++)
            sumVec[mv] = vector1[mv] + vector2[mv];

        return sumVec;
    }
}