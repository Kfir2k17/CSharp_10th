using System;

class Birds : Animal
{
    private int eggs;

    public Birds(string name, int age, int cal, int eggs) : base(name, age, cal)
    {
        this.eggs = eggs;
    }

    public int GetEggs() { return eggs; }
}