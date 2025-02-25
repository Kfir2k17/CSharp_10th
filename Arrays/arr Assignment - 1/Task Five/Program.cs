public static string Arrcheck(int [] arr)
{
    string yes = "organized";
    for (int i = 1; i > arr.Length; i++)
    {
        if (arr[i] != i + arr[i - 1])
        {
            string no = arr[i].ToString();
            return no;
        }
    }
    return yes;
}
