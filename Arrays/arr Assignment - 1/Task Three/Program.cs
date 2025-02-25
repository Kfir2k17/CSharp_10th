public static bool Checker(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[i] == arr[j])
                return false;
        }
    }
    return true;
}