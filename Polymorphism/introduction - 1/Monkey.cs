using System;

class Monkey : Mammal 
{ 
    private int bananasPerDay; //תכונה פרטית - כמה בננות אוכל הקוף ביום

    public Monkey(string name, int age, int cal, int milk) : base(name, age, cal, milk)
    {
        this.bananasPerDay = 4;
        Console.WriteLine("The mekofef of the bananot");
    }

    public void SetBanana(int bananasPerDay) { this.bananasPerDay = bananasPerDay; }

    public override int Eat()
    {
        this.calPerMeal += this.bananasPerDay * 90;
        return base.Eat();
    }

    public override string ToString()
    { return", Bananas Per Day: " + bananasPerDay; }
}