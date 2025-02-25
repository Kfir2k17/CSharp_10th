static int Sum(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, 0];
        sum += arr[i, arr.GetLength(0)-1];
    }
        

    for (int j = 1; j < arr.GetLength(1)-1; j++)
    {
        sum += arr[0, j];
        sum += arr[arr.GetLength(1)-1 , j];
    }

    return sum;
}

static int OtherSum(int[,] arr)
{
    int sum = 0;
    for(int i = 1; i < arr.GetLength(0)-1; i++)
    {
        for (int j = 1; j < arr.GetLength(1)-1; j++)
            sum += arr[i, j];
    }
    return sum;
}

static bool Isit(int[,] arr)
{
    return (Sum(arr) == OtherSum(arr));
}