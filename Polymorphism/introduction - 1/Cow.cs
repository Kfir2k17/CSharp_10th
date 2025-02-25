using System;

class Cow : Mammal
{
    private int spots;
    public Cow(string name, int age, int cal, int milk, int k) : base(name, age, cal, milk)
    {
        this.spots = k;
        Console.WriteLine("para para ");
    }

    public override int Eat()
    {
        return base.Eat() * 4;
    }

    public override string ToString()
    {
        return base.ToString() + "and" + spots + "spots";
    }
}