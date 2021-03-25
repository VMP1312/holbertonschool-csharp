using System;

///<summary>Player</summary>
public class Player
{
    ///<summary>Class</summary>
    private string name;
    private float maxHp;
    private float hp;

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
    }
}
