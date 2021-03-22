using System;

/// <summary>Lenght of a vector</summary>
class VectorMath
{
    /// <summary>Lenght of a vector</summary>
public static double Magnitude(double[] vector)
    {
        if (vector.Length < 2 || vector.Length > 3)
            return -1;

        double res = 0;
        double NLen = new double();

        foreach (double x in vector)
        {
            double sqrt = Math.Pow(x, 2);
            res = res + sqrt;
        }
        NLen = Math.Sqrt(res);
        return Math.Round(NLen, 2); 
    }
}
