class Example
{
    private int example;

    public Example(int example)     //      פעולה בונה
    {
        this.example = example;
    }

    public void Something()     //      פעולה שלא מחזירה דבר, בשימוש על מנת לשנות תכונות
    {
    }

    public int GetExample()     //   פעולה המחזירה את הערך של התכונה
    {
        return example;
    }

    public override string ToString()   //  פעולת טו סטרינג
    {
        return "whatever you want";
    }
}
