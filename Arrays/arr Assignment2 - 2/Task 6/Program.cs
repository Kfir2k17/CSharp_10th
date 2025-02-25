static int[] Parking(int[] times)
{
    int[] number = new int[12];
    for (int x = 0; x < times.Length; x++)
    {
        for(int y = 0; y < number.Length; y++)
        {
            if (times[x]/100 == y+12)
               number[y]++;
        }
    }
    return number;
}

static int[] HowMany(int[] times)
{
    int[] number = Parking(times);
    int max = 0;
    int maxint = 0;
    int min = 50;
    int minint = 0;

    for (int i = 0; i < 12; i++)
    {
        if (number[i] > max)
        {
            max = number[i];
            maxint = i;
        }

        if (number[i] < min)
        {
            min = number[i];
            minint = i;

        }
    }


    int[] extremes = new int[2];
    extremes[0] = maxint + 12;
    extremes[1] = minint + 12;

    return extremes;
}

int[] times = new int[50];
Random rnd = new Random();

for (int i = 0; i < times.Length; i++)
    times[i] = (rnd.Next(12, 24) * 100) + rnd.Next(60);

int[] extremes = HowMany(times);

Console.WriteLine("The busiest hour is {0}:00 and the thinnest(?) hour is {1}:00", extremes[0], extremes[1]);