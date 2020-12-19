using System;

/// <summary> Class Obj</summary>
class Obj
{
    /// <summary> Returns True if the object is an instance of,
    /// or if the object is an instance of a class that inherited from,
    /// Array</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (typeof(Array).IsInstanceOfType(obj))
            return true;
            
        return false;
    }
}

