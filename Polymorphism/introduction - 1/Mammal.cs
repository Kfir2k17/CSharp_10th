using System;

class Mammal : Animal
{
    protected int milk; // כמות חלב שהחיה יונקת

    public Mammal(string name, int age, int cal, int milk) : base(name, age, cal)
    {
        this.milk = milk;
        Console.WriteLine("Mommm");
    }

    public override int Eat()
    {
        return base.Eat() + milk * 2;
    }
    public override string ToString()
    {
        return base.ToString() + "and breastfeeding: " + milk;
    }
    
}