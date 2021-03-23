using System;

/// <summary>Base Class</summary>
public abstract class Base 
{
    public string name;
    
    /// <summary>Overides to string method</summary>
        public override string ToString()
        {
            return name + " is a " + GetType();
        }
}
