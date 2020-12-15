using System;

enum Rating
{
    Good,
    Great,
    Excellent
}
struct Dog
{   
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog(string Name, float Age, string Owner, Rating Rating)
    {
        name = Name;
        age = Age;
        owner = Owner;
        rating = Rating;
    }

    public override string ToString()
    {
        return string.Format("Dog Name: {0}\nAge: {1}\nOwner: {2}\nRating: {3}", name, age, owner, rating);
    }
}
