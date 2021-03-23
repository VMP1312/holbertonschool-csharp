using System;

///<summary>Base Class</summary>
public abstract class Base 
{
    public string name;
    
    ///<summary>Overides to string method</summary>
        public override string ToString()
        {
            return name + " is a " + GetType();
        }
}


///<summary>Interface</summary>
public interface IInteractive
{
    void Interact();
}

///<summary>Interface</summary>
public interface IBreakable
{
    int durability
    { get; set; }
    void Break();
}

///<summary>Interface</summary>
public interface ICollectible
{
    bool isCollected
    { get; set; }
    void Collect();
}

///<summary>Door implementation</summary>
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

///<summary>The Decoration</summary>
public class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem;
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
            Console.WriteLine("You look at the" + name + ". Not much to see here.");
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
