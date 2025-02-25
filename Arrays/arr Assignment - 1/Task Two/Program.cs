public static bool Checker(int[] arr, int i, int j)
{
    
    while (j >= i)
    {
        if (arr[j] != arr[i])
            return false;
        i++;
    }
    return true;
}