static int[] Build(int[] arr)
{
    int[] res = new int[arr.Length];
    int num = 0;
    int sum = 0;
    int counter = 0;

    for (int x = 0; x < arr.Length; x++)
    {
        if (arr[x] <= num)
        {
            res[counter++] = sum;
            sum = 0;
        }

        sum += arr[x];

        num = arr[x];
    }

    res[counter] = sum;

    return res;
}