public static bool Innit(int[] arr, int x)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == x) 
            return true;
    }
    return false;
}