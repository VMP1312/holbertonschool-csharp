using System;

/// <summary>Lenght of a vector</summary>
class VectorMath
{
    /// <summary>Lenght of a vector</summary>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length >= 2 && vector.Length <= 3)
        {
            double acum = 0;

            double lenVec = new double();

            foreach (double x in vector)
            {
                double sqrt = Math.Pow(x, 2);
                acum = acum + sqrt;
            }

            lenVec = Math.Sqrt(res);
            return Math.Round(lenVec, 2);
        }

        return -1;
    }
}
