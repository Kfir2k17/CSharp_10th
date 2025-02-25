using System;
class Animal
{
    protected string name;// שם החיה
    protected int age; // גיל החיה
    protected int calPerMeal;   //קלרויות לארוחה אחת

    public Animal(string name, int age, int cal)
    {
        this.name = name;
        this.age = age;
        this.calPerMeal = cal;
        Console.WriteLine("Animosh");
    }

    public virtual int Eat() { return calPerMeal*3; }

    public string GetName()
    {
        return this.name;
    }

    public override string ToString()
    {
        return " Name: " + this.name + " (age : " + this.age + " ) is eating " + this.Eat() + " calories";
    }

}