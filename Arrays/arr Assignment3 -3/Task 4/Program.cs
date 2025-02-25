using System.Runtime.InteropServices;

static bool WhichSide(int[] arr, int x)
{
    int place = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == x)
        {
            place = i; 
            break ;
        }
    }
    if (place > arr.Length / 2)
        return true;
    
    else
        return false;
}

static int HowMany(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length/2; i++)
    {
        if (WhichSide(arr, arr[i]))
            counter++;
    }
    return counter;
}