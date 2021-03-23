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

public class TestObject : Base, IInteractive, IBreakable, ICollectible
{
    public int durability
    { get; set; }
	public bool isCollected
    { get; set; }
    public void Interact()
    {}
    public void Break()
    {}
    public void Collect()
    {}
}
