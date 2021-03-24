using System;
using System.Collections.Generic;
using System.Collections;
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
public interface ICollectable
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


///<summary>The Decoration</summary>
public class Decoration : Base, IInteractive, IBreakable
{
    ///<summary>Property</summary>
    public bool isQuestItem;
    ///<summary>Property</summary>
    public int durability
    { get; set; }

    /// <summary>The Decoration constructor</summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    ///<summary>Interact Implementation</summary>
    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine("The " + name + " has been broken.");
        else if (isQuestItem == true)
            Console.WriteLine("You look at the " + name + ". There's a key inside.");
        else
            Console.WriteLine("You look at the " + name + ". Not much to see here.");
    }

    ///<summary>Break Implementation</summary>
    public void Break()
    {
        durability--;

        if (durability > 0)
            Console.WriteLine("You hit the " + name + ". It cracks.");
        else if (durability == 0)
            Console.WriteLine("You smash the " + name + ". What a mess.");
        else if (durability < 0)
            Console.WriteLine("The " + name + " is already broken.");
    }
}

///<summary>Using Keys</summary>
public class Key : Base, ICollectable
{
    ///<summary>Property</summary>
    public bool isCollected
    { get; set; }

    /// <summary>Constructor</summary>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }
    ///<summary>Collect</summary>
    public void Collect()
    {
        if (isCollected == false)
            Console.WriteLine("You pick up the " + name + ".");
        else if (isCollected == true)
        {
           Console.WriteLine("You have already picked up the " + name + "."); 
        }
        this.isCollected = true;
    }
}

/// <summary>Class generic t</summary>
class Objs<T> : IEnumerable<T> 
{
  List<T> objects = new List<T> ();
   
   public void Add(T item)
    {
      objects.Add(item);
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (T item in objects)
        {
            yield return (item);
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}