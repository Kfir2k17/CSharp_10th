using System.Reflection.Metadata.Ecma335;
static bool Trueorfalse(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length; j++) 
        {
            if (num == arr[i]+arr[j] && arr[i] != arr[j] && num != arr[i] && num != arr[j])
                return true;
        }
    }
    return false;
}
