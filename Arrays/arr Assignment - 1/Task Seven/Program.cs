public static int Larging(int[] arr)
{
    int num = 0; int max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        while (num != 9)
        {
            num *= 10;
            num += arr[i];
        }
        if (num >= max)
            max = num;
        num = 0;
    }
}