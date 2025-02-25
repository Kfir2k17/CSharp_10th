static bool Tmoora(int[,] mat)
{
    
    int n = mat.GetLength(1);
    int factoral = 0;
    for (int i = 0; i < n; i++)
        factoral *= i;
    
    for (int i = 0; i < n; i++)
        factoral += i;
    
    for(int x = 0; x < mat.GetLength(0); x++)
    {
        int max = 0;
        for (int y = 0; y < mat.GetLength(1); y++)
        {
            max += mat[x, y];
        }
        if (max != factoral)
            return false;
    }
    return true;

}