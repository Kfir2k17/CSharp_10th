static bool Init(int num, int d)
{
    if (d == num % 10)
        return true;

    if (num == 0)
        return false;
    
    return (Init(num / 10, d));
}