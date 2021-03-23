using System;

/// <summary>Base Class</summary>
public abstract class Base 
{
    ///<summary>Public name</summary>
    public string name;
    
    /// <summary>Overides to string method</summary>
        public override string ToString()
        {
            return name + " is a " + GetType();
        }
}


/// <summary>Interface</summary>
public interface IInteractive
{
    ///<summary>Method</summary>
    void Interact();
}

/// <summary>Interface</summary>
public interface IBreakable
{
    ///<summary>Property</summary>
    int durability
    { get; set; }
    ///<summary>Method</summary>
    void Break();
}

/// <summary>Interface</summary>
public interface ICollectible
{
    ///<summary>Property</summary>
    bool isCollected
    { get; set; }
    ///<summary>Method</summary>
    void Collect();
}

///<summary>Door implementation</summary>
public class Door : Base, IInteractive
{
    ///<summary>Door constructor</summary>
    public Door(string door = "Door")
    {
        name = door;
    }
    ///<summary>Method</summary>
    public void Interact()
    {
        Console.WriteLine("You try to open the " + name +". It's locked.");
    }
}
