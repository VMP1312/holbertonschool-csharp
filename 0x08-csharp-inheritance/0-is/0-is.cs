using System;

/// <summary> Class Obj</summary>
class Obj
{
    /// <summary> Mreturns True if the object is an int</summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int)
            return true;

        return false;
    }
}
