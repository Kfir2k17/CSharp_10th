using System.Runtime.ExceptionServices;

static bool Isodd(int num)
{
    while (num > 0)
    {
        if ((num % 10) % 2 == 0)
            return false;
        num /= 10;
    }
    return true;
}

static int HowMany(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (Isodd(arr[i]) == true)
            counter++;
    }
    return counter;
}