int[] a = new int[10];
int[] b = new int[15];

int amount = 0;

for (int x = 0; x < b.Length; x++)
{
    for (int y = 0; y < a.Length; y++)
    {
        if (b[x] == a[y])
            amount++;
    }
}

int[] c = new int[amount];

for (int x = 0; x < b.Length; x++)
{
    for (int y = 0; y < a.Length; y++)
    {
        if (b[x] == a[y])
            c[x] = b[x];
    }
}