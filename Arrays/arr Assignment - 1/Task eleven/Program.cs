int[] m = new int[30];
int n = 0;

for (int i = 0; i < m.Length; i++)
{
    if (i % 2 != 0)
        m[i] = n;

    else
        m[i] = -n;

    n += 2;
    Console.WriteLine(m[i]);
}