public static int Isitgoinup(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > arr[i + 1])
            Console.Write("{0} ", arr[i+1]);
    }
}