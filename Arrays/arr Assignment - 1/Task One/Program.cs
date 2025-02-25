public static bool Checker(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[0] != arr[i])
            return false;
    }
    return true;
}