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


/// <summary>Interface</summary>
public interface IInteractive
{
    void Interact();
}

/// <summary>Interface</summary>
public interface IBreakable
{
    int durability
    { get; set; }
    void Break();
}

/// <summary>Interface</summary>
public interface ICollectible
{
    bool isCollected
    { get; set; }
    void Collect();
}

/// <summary>Door implementation</summary>
public class Door : Base, IInteractive
{
    public Door(string door = "Door")
    {
        name = door;
    }

    public void Interact()
    {
        Console.WriteLine("You try to open the " + name +". It's locked.");
    }
}
