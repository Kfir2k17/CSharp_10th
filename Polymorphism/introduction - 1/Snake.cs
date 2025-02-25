using System;

class Snake : Reptile
{
    private bool rc; // תכונה פרטית - האם נחש ארסי

    public Snake(string name, int age, int cal, int legs, bool rc) : base(name, age, cal, legs)
    {
        this.rc = rc;
        Console.WriteLine("Psss");
    }

    public override string ToString()
    {
        return base.ToString() + "and dangerous: " + rc;
    }
}