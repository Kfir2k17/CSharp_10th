using System.Text.RegularExpressions;

public static bool Tavim(char[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        for (int j = 0; j < a.Length; j++)
        {
            if (a[i] == a[j] && a[i] == '+' || a[i] == a[j] && a[i] == '-')
                return true;
        }
    }
    return false;
}