﻿using System;

/// <summary> Class Shape</summary>
class Shape
{
/// <summary> Method Area checker</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary> Class Rectangle that inherits from class Shape</summary>
class Rectangle : Shape 
{
    private int width;
    private int height;
    
    /// <summary> Gets/sets width of Rectangle</summary>
    public int Width 
    {
        get 
        { 
            return width; 
        }
        
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");

            width = value;
        }
    }

    /// <summary> Gets/sets height of Rectangle</summary>
    public int Height 
    {
        get 
        { 
            return height; 
        }

        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");

            height = value;
        }
    }

}
