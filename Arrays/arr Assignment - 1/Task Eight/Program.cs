int[] arry = new int[44];
for (int i = 0; i < arry.Length; i++)
    { 
    if (arry[i + 1] == arry[i] + 1)
        Console.WriteLine("{0}, {1}", arry[i], arry[i+1]);
    }