static bool Pali(int[] arr)
{
    for (int left = 0, right = arr.Length - 1; left < right; left++, right--)
    {
        if (arr[left] != arr[right])
            return false;
    }
    return true;
}

static bool Pali2(int[] arr, int n)
{
    int[] res = new int[n];

    for (int x = 0; x < arr.Length - n + 1; x++)
    {
        int counter = 0;

        for (int i = 0; i < n; i++)
        {
            res[counter++] = arr[x + i];
        }

        if (Pali(res))
            return true;
    }
    return false;
}

static int Pali3(int[] arr)
{
    int max = 0;
    int counter = 0;
    int j = 0;

    for (int i = 2; i <= arr.Length; i++)
    {
        if (Pali2(arr, i) && i > max)
        {
            max = i;
            counter = j - 2;
        }

        j++;
    }

    return counter;
}

static int[] Pali4(int[] arr)
{
    int max = 0;
    int counter = 0;
    int j = 0;

    for (int i = 2; i <= arr.Length; i++)
    {
        if (Pali2(arr, i) && i > max)
        {
            max = i;
            counter = j - 2;
        }

        j++;
    }

    int[] res = new int[max];
    int x = counter - 1;
    int counter1 = 0;

    for (int i = x; i < x+max; i++)
    {
        res[counter1++] = arr[i];
    }

    return res;
}

int[] arr = new int[40];
a
for (int i = 0; i <= 40; i++)
{
    Console.WriteLine("Please enter the {0} number", i);
    arr[i] = int.Parse(Console.ReadLine());
}

Pali4(arr);

