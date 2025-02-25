using System.Diagnostics.Metrics;
using System.Xml.Schema;

static int[] Seqs(int[] arr)
{
    int amount = 1;
    bool stop = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == -9 && i != arr.Length - 1) 
        amount++;
    }

    int[] newarr = new int[amount];

    int y = 0;

    for (int x = 0; x < newarr.Length; x++)
    {
        while (arr[y] != -9)
        {
            newarr[x] *= 10;
            newarr[x] += arr[y];
            y++;
        }
        y++;
    }

    return newarr;
}

static int Min(int[] arr)
{
    int[] newarr = Seqs(arr);
    int min = int.MaxValue;
    for (int i = 0; i < newarr.Length; i++)
    {
        int counter = 0;

        while (newarr[i] > 0) 
        {
            counter++;
            newarr[i] /= 10;
        }

        if (counter < min)
            min = counter;
    }

    return min;
}