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

///<summary>Tester</summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectible
{
    ///<summary>Property</summary>
    public int durability
    { get; set; }
    ///<summary>Property</summary>
	public bool isCollected
    { get; set; }
    ///<summary>Property</summary>
	public string name
    { get; set; }
    ///<summary>Method</summary>
    public void Interact()
    { }
    ///<summary>Method</summary>
    public void Break()
    { }
    ///<summary>Method</summary>
    public void Collect()
    { }
}
