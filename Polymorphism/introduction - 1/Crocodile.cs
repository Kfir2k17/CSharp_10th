internal class Crocodile : Reptile
{
    private int teeth;

    public Crocodile(string name, int age, int cal, int legs, int teeth) :base(name, age, cal, legs)
    {
        this.teeth = teeth;
    }

    public int GetTeeth() { return teeth; }
}
