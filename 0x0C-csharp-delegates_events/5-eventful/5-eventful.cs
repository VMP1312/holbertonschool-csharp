using System;

/// <summary>Enum</summary>
public enum Modifier
{
    ///<summary>Waek</summary>
    Weak,
    ///<summary>Base</summary>
    Base,
    ///<summary>Strong</summary>
    Strong
}

///<summary>Class</summary>
public class CurrentHPArgs : EventArgs
{
    ///<summary>Property</summary>
    public readonly float currentHp;

    ///<summary>Constructor</summary>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}

///<summary>Calculate Modifier</summary>

public delegate float CalculateModifier(float baseValue, Modifier modifier);

///<summary>Player</summary>
public class Player
{
    ///<summary>Class</summary>
    private string name;
    private float maxHp;
    private float hp;

     /// <summary>Eventhandler</summary>
    EventHandler<CurrentHPArgs> HPCheck;
    private string status;

    ///<summary>Constructor</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0f)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
            this.maxHp = maxHp;
            
        this.name = name;
        this.hp = this.maxHp;
        this.status = this.name + "is ready to go!";
        HPCheck = HPCheck + CheckStatus;
    }

    ///<summary>Method</summary>
    public void PrintHealth()
    {
       Console.WriteLine(this.name + " has " + this.hp + " / " + this.maxHp + " health");
    }

    ///<summary>Delegate takes float</summary>
    public delegate void CalculateHealth(float dam);

    ///<summary>Method</summary>
    public void TakeDamage(float damage)
    {
        float newHP = this.hp;
        if (damage <= 0f)
            damage = 0f;
        Console.WriteLine(this.name + " takes " + damage + " damage!");
        newHP = newHP - damage;
        ValidateHP(newHP);
    }

    ///<summary>Method</summary>
    public void HealDamage(float heal)
    {
        float newHP = this.hp;
        if (heal <= 0f)
            heal = 0f;
        Console.WriteLine(this.name + " heals " + heal + " HP!");
        newHP = newHP + heal;
        ValidateHP(newHP);
    }

    ///<summary>Method</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0f)
            this.hp = 0f;
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else
            this.hp = newHp;
       OnCheckStatus(new CurrentHPArgs(this.hp));
    }

    ///<summary>Apply Modifier</summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
       if (modifier == Modifier.Weak)
            return (baseValue / 2f);
        else if (modifier == Modifier.Strong)
            return (baseValue * 1.5f);
        else
            return (baseValue);
    }

    ///<summary>Check Status</summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {

        if (e.currentHp == this.maxHp)
            this.status = (this.name + " is in perfect health!");
        else if (e.currentHp >= (this.maxHp / 2f) && e.currentHp < this.maxHp)
            this.status = (this.name + " is doing well!");
        else if (e.currentHp >= (this.maxHp * 0.25f) && e.currentHp < (this.maxHp / 2f))
			this.status = (this.name + " isn't doing too great...");
		else if (e.currentHp > 0f && e.currentHp < (this.maxHp * 0.25f))
            	this.status = (this.name + " needs help!");
		else
			this.status = (this.name + " is knocked out!");
		Console.WriteLine(this.status);
    }

    ///<summary>HP warning</summary>
    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
            Console.WriteLine("Health has reached zero!");
        else
            Console.WriteLine("Health is low!");
    }

    ///<summary>OnCheck</summary>
     void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp < (this.maxHp / 4))
            HPCheck += HPValueWarning;
        HPCheck(this, e);
    }
}
