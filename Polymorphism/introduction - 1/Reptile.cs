using System;

class Reptile : Animal
{
    protected int legs; // כמות רגליים

    public Reptile(string name, int age, int cal, int legs) : base(name, age, cal)
    {
        this.legs = legs;
        Console.WriteLine("Rep");
    }
}