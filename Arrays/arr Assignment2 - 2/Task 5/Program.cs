static int[] Organizer1(int[] arr)
{
    int[] arr2 = new int[arr.Length];
    int counter1 = 0;
    int counter2 = 0;

    while (counter1 < arr.Length)
    {
        int moving = 1;
        for (int x = counter1 + 1; x < arr.Length; x++)
        {
            if (IsExist(arr, counter1) == false)
            {
                if (arr[counter1] == arr[x])
                {
                    arr2[counter2] = arr[counter1];
                    arr2[counter2 + moving] = arr[counter1];
                    moving++;
                }

                else
                    arr2[counter2] = arr[counter1];

                counter2 += moving;
            }
            counter1++;
        }
    }
    return arr2;
}
static bool IsExist(int[] arr, int counter1)
{
    for (int i = 0; i < counter1; i++)
    {
        if (arr[i] == arr[counter1])
            return true;
    }
    return false;
}
static int Organizer2(int[] arr)
{
    int[] arr_full = Organizer1(arr);
    int max = 0;
    int counter = 0;
    for (int i = counter; i < arr_full.Length; i++)
    {
        int length = 1;
        while (arr_full[i] == arr[counter])
        {
            length++;
            counter++;
        }
        if (max < length)
            max = length;
        counter++;
    }
    return max;
}

int[] arr = new int[44];
for (int i = 0; i < 44; i++)
{
    Console.WriteLine("Please enter number " + i);
    arr[i] = int.Parse(Console.ReadLine());
}

int max = Organizer2(arr);
Console.WriteLine("The length of the largest sequence is " + max);