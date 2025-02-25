
static int RulingLine(int[,] mat)
{
    int[] lines = Checker(mat);

    int max = 0;
    int max_int = 0;

    for (int i = 0; i < lines.Length; i++)
    {
        if (lines[i] > max)
        {
            max = lines[i];
            max_int = i;
        }
    }
    if (lines[max_int] == mat.GetLength(1))
        return max_int;
    return -1;
}

static int[] Checker(int[,] mat)
{
    int[] lines = new int[mat.GetLength(1)];

    for(int i = 0; i < mat.GetLength(1); i++)
        lines[LineChecker(mat, i)]++;
    return lines;
}

static int LineChecker(int[,] mat, int num)
{
    int max = 0;
    int max_int = 0;
    for(int x = 0; x < mat.GetLength(0); x++)
    {
        if (max < mat[x, num])
        {
            max = mat[x, num];
            max_int = x;
        }
    }
    return max_int;
}
