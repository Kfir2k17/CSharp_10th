using System.Security.AccessControl;

public static string Stair(int[] arr)
{
    string stairs = "stairs";
    string regular = "regular";
    int num = arr[2] - arr[1];

    for (int i = 1; i < arr.Length; i += 2)
    {
        if (arr[i] != arr[i - 1] && num != arr[i + 1] - arr[i])
            return regular;
        num = arr[i+1] - arr[i];
    }
    return stairs;
}