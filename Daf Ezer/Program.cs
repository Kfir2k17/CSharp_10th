//רשימות
using Unit4.CollectionsLib;

public static int Length(Node<string> l) // מחזירה אורך רשימה
{
    Node<string> lst = l;
    int total = 0;
    while (lst != null)
    {
        total++;
        lst = lst.GetNext();
    }
    return total;
}

//תורים
public static int SizeOfQueue(Queue<int> q)
{
    Queue<int> tmp = new Queue<int>();
    int counter = 0;
    while (!q.IsEmpty())
    {
        counter++;
        tmp.Insert(q.Remove());
    }
    while (!tmp.IsEmpty())
    {
        q.Insert(tmp.Remove());
    }
    return counter;
}

public static bool InQueue(Queue<int> q, int x)
{
    int current;
    bool found = false;
    Queue<int> temp = new Queue<int>();
    while (!q.IsEmpty())
    {
        current = q.Remove();
        temp.Insert(current);
        if (current == x)
        {
            found = true;
        }
    }
    while (!temp.IsEmpty())
    {
        q.Insert(temp.Remove());
    }
    return found;
}

public static 

public static Queue<kind> CopyQueue(Queue<kind> q) // פעולה המקבלת תור והופכת אותו
{
    Queue<kind> copy1 = new Queue<kind>();
    Queue<kind> copy2 = new Queue<kind>();
    while (!q.IsEmpty())
    {
        kind x = q.Remove();
        copy1.Insert(x);
        copy2.Insert(x);
    }
    while (!copy2.IsEmpty())
    {
        q.insert(copy2.Remove());
    }
    return copy1;
}

public static void Reverse(Queue<int> q) // פעולה רקורסיבית המקבלת תור והופכת אותו
{
    if (!q.IsEmpty())
    {
        int x = q.Remove();
        Reverse(q);
        q.Insert(x);
    }
}

public static void Print(Queue<kind> t)//מדפיסה תור תווים
{
    Queue<kind> q = Copy(t);
    Queue<kind> t1 = new Queue<kind>();
    while (!q.IsEmpty())
        t1.Insert(q.Remove());
    while (!t1.IsEmpty())
    {
        Console.Write(t1.Remove() + " ");
    }
    Console.WriteLine();
}

static void Main(string[] args)
{
}