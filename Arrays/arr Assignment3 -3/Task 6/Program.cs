using System.Diagnostics.Metrics;

static bool Sorted(int[] arr)
{
    int counter = 0;

    for (int i = 0; i < arr.Length;i++)
    {
        if (arr[i] < arr[i + 1])
            counter++;
    }

    if (counter >= arr.Length / 2)
        return true;

    return false;
}