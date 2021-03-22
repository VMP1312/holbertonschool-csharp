using System;

/// <summary>Multiplies a vector and a scalar and returns the resulting vector</summary>
class VectorMath
{
    /// <summary>Multiplies a vector and a scalar and returns the resulting vector</summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] err = {-1};
        if (vector.Length < 2 || vector.Length > 3)
            return err;

        double[] newVector = new double[vector.Length];

        for (int mv = 0; mv < vector.Length; mv++)
            newVector[mv] = scalar * vector[mv];

        return newVector;
    }
}
