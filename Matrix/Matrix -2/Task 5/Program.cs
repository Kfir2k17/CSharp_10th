static bool Isit(int[,] arr)
{
    bool isit = true;
    isit = Frame(arr);
    isit = Slant(arr);
    return isit;
}

static bool Frame(int[,] arr)
{
    bool okay = true;
    for (int i = 0; i < arr.GetLength(0); i++)
    { 
        if(arr[i, 0] != 1 && arr[i, arr.GetLength(0) - 1] != 1)
          okay = false; 
    }


    for (int j = 1; j < arr.GetLength(1) - 1; j++)
    {
        if (arr[0, j] != 1 && arr[arr.GetLength(1) - 1, j] != 1)
            okay = false;
    }

    return okay;
}


static bool Slant(int[,] arr)
{
    int counter = arr.GetLength(0);
    for (int i = 1; i < arr.GetLength(0)-1; i++)
    {
        for (int j = 1; j < arr.GetLength(1)-1; j++)
            if (arr[i, j] != 0 && j != counter && i != j || arr[i, j] != 1 && i == j && j == counter)
                return false;
            counter--;
    }
    return true;
}