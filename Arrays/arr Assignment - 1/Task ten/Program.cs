public static void Calc(int[] change)
{
    for (int i = 0; i < change.Length; i++)
    {
        int total = 0;

        for (int j = 0; j < change[i];j++)
        {
            if (j % 3 == 0)
            {
                total += j;
            }
        }

        change[i] = total;  
    }
}