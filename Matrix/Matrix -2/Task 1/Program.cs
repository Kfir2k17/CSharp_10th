static bool Slant(int[,] arr)
{
    int counter = arr.GetLength(1) - 1;
    for (int i = 0; i < arr.GetLength(0); i++, counter--)
    {
        if (arr[i, i] <= arr[i + 1, i + 1] && arr[i, counter] <= arr[i + 1, counter - 1])
            return false;
    }
    return true;
}