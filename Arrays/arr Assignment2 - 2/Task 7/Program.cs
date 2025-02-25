static bool Isokay(int[] monthes, int day, int month)
{
    if (month <= 12 && monthes[month] >= day)
        return true;
    return false;
}

static int Period(int day1, int mon1, int day2, int mon2, int[] monthes)
{
    if (!Isokay(monthes, day1, mon1) || !Isokay(monthes, day2, mon2))
        return -1;

    int time = (mon1-day1) + (mon2-day2);

    for (int i = monthes[mon1]; i < monthes[mon2 - 1]; i++)
        time += monthes[i];

    return time;
}